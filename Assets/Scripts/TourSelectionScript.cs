using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourSelectionScript : MonoBehaviour
{
    private bool collided;
    private void Start()
    {
        collided = false;
    }
    private void OnMouseDown()
    {
        collided = !collided;
    }

    private void Update()
    {
        if (collided)
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            Vector3 target = castPoint.origin;
            target.z = transform.position.z;
            transform.position = target;
        }
    }
}
