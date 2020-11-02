using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_MovePlayer : MonoBehaviour
{

    Rigidbody myRigidbody;

    public float speed = 10;
    public float jumpPower = 10;

    int jumpTime = 0;

    // Camera cam;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        // cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerJump();
        KillSelf();
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject otherGameObject = other.gameObject;

        if (otherGameObject.tag == "ground")
        {
            jumpTime = 0;
        }
    }

    public void PlayerMove()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(xInput, 0f, zInput);
        dir.Normalize();

        myRigidbody.MovePosition(transform.position + (dir * speed * Time.deltaTime));
        // cam.transform.position = transform.position;
    }

    public void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && jumpTime == 0)
        {
            myRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            jumpTime = 1;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 35;
        }
        else
        {
            speed = 10;
        }
    }

    public void KillSelf()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            dgkim_ArmagedonManager am = GameObject.Find("ArmagedonManager").GetComponent<dgkim_ArmagedonManager>();
            am.KillPlayer();
        }
    }


    // Check for GitHub Contribution.

}
