using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
 

    public GameObject trapPosition;

    bool destroyTrap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trap"))
        {
            other.gameObject.transform.position = trapPosition.transform.position;
        }

    }

    private void Update()
    {
        
    }
}
