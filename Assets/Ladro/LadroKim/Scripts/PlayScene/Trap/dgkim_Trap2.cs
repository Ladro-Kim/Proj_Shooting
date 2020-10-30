using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap2 : MonoBehaviour
{
    public GameObject start;
    public GameObject end;

    public float moveSpeed = 0.01f;
    public float pushPower = 15.0f;

    Vector3 startPoint;
    Vector3 endPoint;

    int moveIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = start.transform.position;
        endPoint = end.transform.position;

        transform.position = startPoint;

    }

    // Update is called once per frame
    void Update()
    {
        if (moveIndex == 0)
        {
            transform.position = Vector3.Lerp(transform.position, endPoint, moveSpeed);

            if(Vector3.Distance(transform.position, endPoint) <= 0.01)
            {
                moveIndex = 1;
            }
        }

        if (moveIndex == 1)
        {
            transform.position = Vector3.Lerp(transform.position, startPoint, moveSpeed);
            if (Vector3.Distance(transform.position, startPoint) <= 0.01)
            {
                moveIndex = 0;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (moveIndex == 0 && Vector3.Distance(transform.position, endPoint) > 0.5)
        {
            Rigidbody otherRigid = other.gameObject.GetComponent<Rigidbody>();
            Vector3 dir = other.transform.position - transform.position;
            dir.Normalize();
            otherRigid.AddForce(dir * pushPower, ForceMode.Impulse);
        }


        
    }
}
