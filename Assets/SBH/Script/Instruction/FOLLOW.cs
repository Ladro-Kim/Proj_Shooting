using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOW : MonoBehaviour
{

    public GameObject _FOLLOW;
    public GameObject Location;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("hip"))
        {
            GameObject go = Instantiate(_FOLLOW);
            go.transform.position = Location.transform.position;
            go.transform.localScale = new Vector3(0.05227618f, 0.05227618f, 0.05227618f);
        }

    }
}
