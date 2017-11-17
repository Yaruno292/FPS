using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public Transform target;
    public float speed;
    Vector3 TargetPostion = new Vector3(0, 1, 0);
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Body");
        TargetPostion = player.transform.position;
    }


    void Update()
    {
        player = GameObject.Find("Body");
        TargetPostion = player.transform.position;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, TargetPostion, step);
    }
}
