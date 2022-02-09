using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public Camera cam;

    public NavMeshAgent agent;

    public LayerMask layerMask;

    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            

            if (Physics.Raycast(ray,  out hit, float.MaxValue, layerMask))
            {
                agent.SetDestination(hit.point);
            }

            

        }
        if (agent.hasPath)
        {
            if(animator.GetBool("isWalking") != true)
            {
                //animator.StopPlayback
            }
            animator.SetBool("isWalking", true);
            //animator.
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

    }
}