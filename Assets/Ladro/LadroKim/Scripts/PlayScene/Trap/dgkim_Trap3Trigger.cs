using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap3Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Trap3")
        {
            other.gameObject.GetComponent<dgkim_Trap3>().index = 1;
            Destroy(gameObject, 1f);
        }
    }
}
