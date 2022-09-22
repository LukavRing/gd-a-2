using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public Camera cam;
    private NavMeshAgent agent;

    public GameObject handGrabPos;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);

                if (hit.transform.CompareTag("Grabbable"))
                {
                    animator.SetTrigger("Interact");
                    hit.transform.position = handGrabPos.transform.position;
                    hit.transform.parent = handGrabPos.transform;
                }
                
            }
        }
    }
}
