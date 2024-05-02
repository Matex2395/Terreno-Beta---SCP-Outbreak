using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDisappearsOnTouch : MonoBehaviour
{
    public LayerMask playerLayer; 
    public float detectionRadius = 1f; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == playerLayer)
        {
            gameObject.SetActive(false);
        }
    }
}
