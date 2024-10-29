using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI; 

 [RequireComponent(typeof(NavMeshAgent))]
public class MoveFollower : MonoBehaviour
{
    private Vector3 destination;

   
    [SerializeField] private NavMeshAgent playerNavMesh;

    [SerializeField] private Vector3 offsetVector;
    [SerializeField] private float offsetValue;
    [SerializeField] private GameObject target;

    void Awake()
    {

    }

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        offsetValue = 1f;
        destination = transform.position;
        playerNavMesh = this.GetComponent<NavMeshAgent>();
        offsetVector = new Vector3(offsetValue, -offsetValue, 0);
    }

    void Update()
    {
        destination = target.transform.position - offsetVector;
        playerNavMesh.SetDestination(destination);
    }

}
