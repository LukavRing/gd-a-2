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
    
    public GameObject player;
    
    public float counterTime = 5f;
    float counter = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        myAgent = GetComponent<NavMeshAgent>();
        wanderPoints = GameObject.FindGameObjectsWithTag("WanderPoint");
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartWander()
    {
        myAgent = GetComponent<NavMeshAgent>();
        setRandomHeading();
    }
    public void FixedUpdateWaner()
    {
        
    }
    public void UpdateWander(){
        counter += 1f * Time.deltaTime;
        if (counter >= counterTime)
        {
            setRandomHeading();
            counter = 0;
        }
    }

    public void StartGoToPlayer()
    {
        myAgent.SetDestination(player.transform.position);
    }

    public void UpdateGotoPlayer()
    {
        myAgent.SetDestination(player.transform.position);
    }

    public void StartRun()
    {
    }

    public void UpdateRun()
    {
        setRandomHeading();
    }

    private void setRandomHeading()
    {
        int choice = Random.Range(0, wanderPoints.Length -1);
        headingPoint = wanderPoints[choice].transform;
        myAgent.SetDestination(headingPoint.position);
    }

    public bool distanceToPlayer()
    {
        print(Vector3.Distance(player.transform.position, transform.position));
        return Vector3.Distance(player.transform.position, transform.position) <= 10f;
    }
}
