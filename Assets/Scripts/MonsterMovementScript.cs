using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovementScript : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;


    private Transform target;
    private int destPoint;

    void Start()
    {
        target = waypoints[1];
        destPoint = 1;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        var t2 = new Vector2(target.position.x, target.position.y);
        transform.position = Vector2.MoveTowards(transform.position, t2, step);
        if (Vector3.Distance(transform.position, t2) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
}
