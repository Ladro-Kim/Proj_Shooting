using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class dgkim_Keeper : MonoBehaviour
{
    public GameObject player;
    Rigidbody myRigid;

    float xRandom, zRandom;

    Vector3 destPos;

    float speed = 4f;

    bool isArrived;
    bool isFind;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();

        xRandom = Random.Range(8.7f, 17f);
        zRandom = Random.Range(126.63f, 137.19f);

        destPos = new Vector3(xRandom, 34.8f, zRandom);
    }

    // Update is called once per frame
    void Update()
    {
        if (isFind)
        {

        }
        else
        {
            // 플레이어와 상호작용
            float playerToKeeper = Vector3.Distance(player.transform.position, transform.position);
            if (playerToKeeper < 3)
            {
                isFind = true;
                // 플레이어 따라가기
            }
            else
            {
                // 목적지 관련
                float destToKeeper = Vector3.Distance(destPos, transform.position);
                print(destToKeeper);
                if (destToKeeper < 3)
                {
                    xRandom = Random.Range(8.7f, 17f);
                    zRandom = Random.Range(126.63f, 137.19f);

                    destPos = new Vector3(xRandom, 37.8f, zRandom);
                }
                else
                {
                    Vector3 dir = destPos - transform.position;
                    dir.Normalize();
                    
                    // transform.position += dir * speed * Time.deltaTime;
                    // myRigid.MovePosition(destPos);
                    transform.position = Vector3.MoveTowards(transform.position, destPos, 4f * Time.deltaTime);
                }

            }
        }
    }

    void OnCollisionEnter(Collision other)
    {

    }

}
