using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGrab : MonoBehaviour
{
    public string Tag;
    public KeyCode grabKey;
    public GameObject Objeto;
    public bool conected;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(grabKey) && Objeto)
        {
            if (Objeto.GetComponent<Rigidbody>())
            {
                if (!gameObject.GetComponent<SpringJoint>())
                {
                    SpringJoint SJ = gameObject.AddComponent<SpringJoint>();
                    SJ.connectedBody = Objeto.GetComponent<Rigidbody>();
                    SJ.spring = 1000;
                }
            }

        }
        else
        {
            Destroy(gameObject.GetComponent<SpringJoint>());
            conected = false;
            Objeto = null;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tag && conected == false)
        {
            if (Input.GetKey(grabKey))
            {
                Objeto = other.gameObject;
                conected = true;
            }
        }
    }
}