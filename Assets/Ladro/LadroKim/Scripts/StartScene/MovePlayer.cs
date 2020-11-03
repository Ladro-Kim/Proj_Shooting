using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float _keySpeed = 5;
    Rigidbody myRigid;

    float jumpPower = 3;

    bool isGround = false;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        InputKey();
        Jump();
    }

    public void InputKey()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0f, z);
        dir.Normalize();

        transform.position += dir * _keySpeed * Time.deltaTime;
    }

    public void Jump()
    {
        if (isGround)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                myRigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                print("AddForce");
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }







}
