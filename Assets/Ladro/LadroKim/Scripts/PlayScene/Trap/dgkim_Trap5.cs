using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap5 : MonoBehaviour
{
    public GameObject player;
    float distanceToPlayer;

    void Start()
    {

    }
    void Update()
    {
        distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
        gameObject.transform.localScale = new Vector3(1, distanceToPlayer, 1);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            gameObject.transform.parent = other.gameObject.transform;
        }
    }
}
