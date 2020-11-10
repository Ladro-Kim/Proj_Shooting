using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap5 : MonoBehaviour
{
    public GameObject player;
    float speed = 100;
    float distanceToPlayer;

    bool isAttached = false;

    void Start()
    {

    }
    void Update()
    {
        if (isAttached)
        {

            gameObject.transform.RotateAround(player.transform.position, Vector3.down, speed * Time.deltaTime);
        }
        else
        {
            distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
            gameObject.transform.localScale = new Vector3(1, distanceToPlayer, 1);
        }


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player") || other.gameObject.name.Contains("hip") || other.gameObject.name.Contains("spine")
            || other.gameObject.name.Contains("RH") || other.gameObject.name.Contains("ra") || other.gameObject.name.Contains("ls")
            || other.gameObject.name.Contains("lt") || other.gameObject.name.Contains("ll") || other.gameObject.name.Contains("rs")
            || other.gameObject.name.Contains("rt") || other.gameObject.name.Contains("rl"))
        {
            gameObject.transform.parent = other.gameObject.transform;
            isAttached = true;
            Manager.manager.playerState = dgkim_Define.State.Finish;
        }
    }


}
