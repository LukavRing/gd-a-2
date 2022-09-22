using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private GameObject[] wanderPoints;

    private Transform headingPoint;
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
    void startWander(){
        
    }
    void fixedUpdateWaner(){
   
    }
    void UpdateWander(){
        
    }
}
