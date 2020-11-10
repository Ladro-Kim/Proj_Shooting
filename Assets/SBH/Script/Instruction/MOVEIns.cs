using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEIns : MonoBehaviour
{
    public GameObject WASD;
    public GameObject Location;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("hip"))
        {
            GameObject go = Instantiate(WASD);
            go.transform.position = Location.transform.position;
            go.transform.localScale = new Vector3(0.08478373f, 0.08478373f, 0.08478373f);
        }
           
    }
}
