using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LETSGO : MonoBehaviour
{
    public GameObject _LETSGO;
    public GameObject Location;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("hip"))
        {
            GameObject go = Instantiate(_LETSGO);
            go.transform.position = Location.transform.position;
            go.transform.localScale = new Vector3(0.1966525f, 0.1966525f, 0.1966525f);
        }

    }
}
