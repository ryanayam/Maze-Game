using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour {

    public GameObject target;
    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.transform.position);
	}
}
