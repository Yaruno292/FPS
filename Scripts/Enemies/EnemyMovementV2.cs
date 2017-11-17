using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementV2 : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent nav;
    Transform player;
    // Use this for initialization
    void Start () {
		
	}
    private void Awake()
    {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    //
    void Update()
    {
        nav.SetDestination(player.position);
    } 
}
