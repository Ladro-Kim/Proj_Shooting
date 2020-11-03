using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Armageddon : MonoBehaviour
{
    Rigidbody myRigidbody;
    public GameObject explosionPrefeb;

    public float speed = 3;

    Vector3 target;
    Vector3 targetPoint;
    Vector3 dir;


    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        dir = target - transform.position;
        dir.Normalize();

        transform.LookAt(dir);
        dir *= speed;
        myRigidbody.AddForce(dir.x, dir.y, dir.z, ForceMode.Impulse);

        Ray ray = new Ray(transform.position, dir);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 200f, LayerMask.GetMask("Ground")))
        {
            targetPoint = hit.point;
            Debug.DrawRay(transform.position, dir * 200f, Color.red, 3f);
        }
    }

    void Update()
    {

        // transform.position += dir * speed * Time.deltaTime;
    }

    public void SetDestination(Vector3 dest)
    {
        target = dest;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (targetPoint == null)
        {
            targetPoint = other.gameObject.transform.position;
        }
        GameObject tempPrefeb = GameObject.Instantiate(explosionPrefeb);
        tempPrefeb.transform.position = targetPoint;
        Destroy(gameObject);
        Destroy(tempPrefeb, 3);

    }

}
