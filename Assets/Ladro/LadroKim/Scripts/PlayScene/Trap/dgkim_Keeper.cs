using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class dgkim_Keeper : MonoBehaviour
{
    public GameObject player;

    float speed = 1f;

    float randX, randY, randZ;
    Vector3 destPos;
    Vector3 dir;

    float playerToMonster;

    float detectDistance = 3;

    bool isArrived = true;
    public bool isInBossZone = false;

    void Start()
    {

    }

    void Update()
    {
        playerToMonster = (player.transform.position - transform.position).magnitude;
        if (playerToMonster < detectDistance)
        {
           if (isInBossZone)
            {
                destPos = player.transform.position;
            }
           else
            {
                destPos = new Vector3(16.4f, 33.8f, 131.37f);
            }
            dir = destPos - transform.position;
            isArrived = false;
        }
        else
        {
            if (isArrived)
            {
                randX = Random.Range(8.22f, 18f);
                randY = Random.Range(33.59f, 34.2f);
                randZ = Random.Range(129f, 134f);

                destPos = new Vector3(randX, randY, randZ);
                dir = destPos - transform.position;
                isArrived = false;
            }
            else
            {
                if (dir.magnitude < 2.5f)
                {
                    isArrived = true;
                }
                else
                {
                    dir = destPos - transform.position;
                    float moveDistance = Mathf.Clamp(speed * Time.deltaTime, 0, dir.magnitude);
                    transform.position += dir.normalized * moveDistance;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 3f * Time.deltaTime);
                }
            }
            print(dir.magnitude);
            print($"{randX} / {randY} / {randZ}");

        }
    }
}
