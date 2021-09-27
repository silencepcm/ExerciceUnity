using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TourSelectionScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log(transform.position);
        Debug.Log(Input.mousePosition);
    }
}
