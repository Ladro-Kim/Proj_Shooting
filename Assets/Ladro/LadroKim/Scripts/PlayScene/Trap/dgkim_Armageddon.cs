using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Armageddon : MonoBehaviour
{
    Rigidbody myRigidbody;
    public GameObject explosionPrefeb;

    public float speed = 10;

    Vector3 target;
    Vector3 dir;

    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        dir = target - transform.position;
        dir.Normalize();

        transform.LookAt(dir);
        dir *= speed;
        myRigidbody.AddForce(dir.x, dir.y, dir.z, ForceMode.Impulse);
    }

    void Update()
    {

        // transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {

        Vector3 tempPos = other.gameObject.transform.position;
        GameObject tempPrefeb = GameObject.Instantiate(explosionPrefeb);
        tempPrefeb.transform.position = tempPos;
        Destroy(gameObject);
        Destroy(tempPrefeb, 3);

        if (other.gameObject.name.Contains("Player"))
        {
            Destroy(other.gameObject, 0.1f);
        }

    }

    public void SetDestination(Vector3 dest)
    {
        target = dest;
    }

}
