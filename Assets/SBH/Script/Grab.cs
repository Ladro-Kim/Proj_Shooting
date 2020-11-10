using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Grab : MonoBehaviour
{
    Renderer capsCol;
    public float power = 4000;
    Rigidbody rb;
    bool stick = false;
    BoxCollider bx;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        capsCol = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (stick)
            return;

        stick = true;

        SpringJoint sp = GetComponent<SpringJoint>();
        sp.connectedBody = collision.rigidbody;
        sp.spring = 12000;
        sp.breakForce = power;


    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpringJoint sp = GetComponent<SpringJoint>();
            if (sp != null)
            {
                sp.connectedBody = null;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            stick = !stick;
            if (stick)
            {
                capsCol.material.color = Color.blue;

            }
            else
            {
                capsCol.material.color = Color.red;
            }

        }
    }
}
