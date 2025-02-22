using UnityEngine;
using System.Collections;

public class NavMesh : MonoBehaviour {
public Transform target;
UnityEngine.AI.NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update() {
    agent.SetDestination(target.position);
        
    }
}
