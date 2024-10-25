using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private Transform target;
    private NavMeshAgent agent;   
    void Start()
    {
        agent=this.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }
}
