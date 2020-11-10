using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Armageddon : MonoBehaviour
{
    Rigidbody myRigidbody;
    public GameObject explosionPrefeb;

    public float speed = 3;
<<<<<<< HEAD
    public AudioSource audiosource;
=======
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1

    Vector3 target;
    Vector3 targetPoint;
    Vector3 dir;

<<<<<<< HEAD
    bool isCollision = false;

=======
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        dir = target - transform.position;
        dir.Normalize();

        transform.LookAt(dir);
        dir *= speed;
        myRigidbody.AddForce(dir.x, dir.y, dir.z, ForceMode.Impulse);

        Ray ray = new Ray(transform.position, dir);
<<<<<<< HEAD

        RaycastHit hit;
        
=======
        RaycastHit hit;
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
        if (Physics.Raycast(ray, out hit, 200f, LayerMask.GetMask("Ground")))
        {
            targetPoint = hit.point;
            Debug.DrawRay(transform.position, dir * 200f, Color.red, 3f);
        }
    }

    void Update()
    {

    }



    public void SetDestination(Vector3 dest)
    {
<<<<<<< HEAD
        target = dest;
    }

    private void OnCollisionEnter(Collision other)
    {
        isCollision = true;
=======
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
        if (targetPoint == null)
        {
            targetPoint = other.gameObject.transform.position;
        }
        GameObject tempPrefeb = GameObject.Instantiate(explosionPrefeb);
        tempPrefeb.transform.position = targetPoint;
<<<<<<< HEAD
        
=======
        Destroy(gameObject);
        Destroy(tempPrefeb, 3);
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1

        //if (other.gameObject.CompareTag("ground"))
        //{
        //    gameObject.GetComponent<MeshRenderer>().enabled = false;
        //}

        if (other.gameObject.name.Contains("hip"))
        {
            Manager.manager.playerState = dgkim_Define.State.Dead;
        }


        Destroy(gameObject);
        Destroy(tempPrefeb, 3f);

        
        



    }



}
