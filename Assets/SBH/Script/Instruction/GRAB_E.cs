using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GRAB_E : MonoBehaviour
{

    public GameObject GRAB;
    public GameObject Location;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("hip"))
        {
            GameObject go = Instantiate(GRAB);
            go.transform.position = Location.transform.position;
            go.transform.localScale = new Vector3(0.08478373f, 0.08478373f, 0.08478373f);
        }

    }
}
