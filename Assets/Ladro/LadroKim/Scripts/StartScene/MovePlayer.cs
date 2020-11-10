using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float _keySpeed = 5;
<<<<<<< HEAD
    Rigidbody myRigid;

    float jumpPower = 3;

    bool isGround = false;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
=======


    void Start()
    {

>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
    }

    void Update()
    {
        InputKey();
<<<<<<< HEAD
        Jump();
=======
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
    }

    public void InputKey()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0f, z);
        dir.Normalize();

        transform.position += dir * _keySpeed * Time.deltaTime;
    }

<<<<<<< HEAD
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




=======
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1



}
