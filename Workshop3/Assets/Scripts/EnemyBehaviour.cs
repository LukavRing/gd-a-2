using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    private NavMeshAgent myAgent;
    public GameObject[] wanderPoints;
    private Transform headingPoint;

    public float counterTime = 5f;
    float counter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        wanderPoints = GameObject.FindGameObjectsWithTag("WanderPoint");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartWander()
    {
        myAgent = GetComponent<NavMeshAgent>();
        setHeading();
    }
    public void FixedUpdateWaner()
    {
        
    }
    public void UpdateWander(){
        counter += 1f * Time.deltaTime;
        if (counter >= counterTime)
        {
            setHeading();
            counter = 0;
        }
    }

    public void StartGoToPlayer()
    {
        
    }

    public void UpdateGotoPlayer()
    {
        
    }

    private void setHeading()
    {
        int choice = Random.Range(0, wanderPoints.Length -1);
        headingPoint = wanderPoints[choice].transform;
        myAgent.SetDestination(headingPoint.position);
    }
}
