using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_UpDown : MonoBehaviour
{
    public float moveSpeed = 0.005f;

    int posIndex = 0;

    public float pushPower = 15f;

    public GameObject downPos;
    public GameObject upPos;

    Vector3 downPoint;
    Vector3 upPoint;

    Rigidbody playerRigid;

    // Start is called before the first frame update
    void Start()
    {
        downPoint = downPos.transform.position;
        upPoint = upPos.transform.position;

        transform.position = downPoint;
    }

    // Update is called once per frame
    void Update()
    {
        if (posIndex == 0)
        {
            transform.position = Vector3.Lerp(transform.position, upPoint, moveSpeed);

            if (Vector3.Distance(transform.position, upPoint) <= 0.01)
            {
                if (playerRigid != null)
                {
                    playerRigid.AddForce(Vector3.up * pushPower);
                }
                posIndex = 1;
            }
        }
        if (posIndex == 1)
        {
            transform.position = Vector3.Lerp(transform.position, downPoint, moveSpeed);

            if (Vector3.Distance(transform.position, downPoint) <= 0.01)
            {
                posIndex = 0;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        playerRigid = collision.gameObject.GetComponent<Rigidbody>();
    }

}
