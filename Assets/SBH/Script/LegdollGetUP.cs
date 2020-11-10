using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegdollGetUP : MonoBehaviour
{
    HingeJoint hj;
    Rigidbody rb;
    CapsuleCollider Cap;

    public Rigidbody headRB;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cap = GetComponent<CapsuleCollider>();
        hj = GetComponent<HingeJoint>();
    }

    float OutValue = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.relativeVelocity.magnitude > OutValue)
        {
            StartCoroutine(Up());

        }
    }

    IEnumerator Up()
    {
        rb.constraints = RigidbodyConstraints.None;
        Cap.enabled = false;
       

        yield return new WaitForSeconds(1);
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        Cap.enabled = true;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            //StartCoroutine(Up());
            Vector3 dir = Vector3.up* 1000;
            headRB.AddForce(dir, ForceMode.Impulse);
            rb.AddTorque(transform.right * 100, ForceMode.Impulse);
        }
    }

}
