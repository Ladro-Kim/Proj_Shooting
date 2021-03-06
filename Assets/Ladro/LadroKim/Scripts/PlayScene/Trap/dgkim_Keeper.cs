﻿using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class dgkim_Keeper : MonoBehaviour
{
    public GameObject player;
    Animator animator;
    Rigidbody myRigid;

    float moveDistance;
    public float speed = 1;

    float randX, randY, randZ;
    Vector3 destPos;
    Vector3 dir;

    float playerToMonster;

    float detectDistance = 3;

    bool isArrived = true;
    public bool isInBossZone = false;

    float tempTime = 0;

    public float pushPower = 6000f;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    void LateUpdate()
    {
        playerToMonster = (player.transform.position - transform.position).magnitude;
        if (playerToMonster <= detectDistance)
        {
            animator.SetBool("isClose", true);

            if (isInBossZone)
            {
                destPos = player.transform.position;
            }
            else
            {
                destPos = new Vector3(16.4f, 33.8f, 131.37f);
            }
            speed = 1.5f;

            dir = destPos - transform.position;

            moveDistance = Mathf.Clamp(speed * Time.deltaTime, 0, dir.magnitude);
            myRigid.MovePosition(transform.position + (dir.normalized * moveDistance));
            // transform.position += dir.normalized * moveDistance;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 3f * Time.deltaTime);



        }
        else
        {
            animator.SetBool("isClose", false);
            speed = 1f;

            if (isArrived)
            {
                randX = Random.Range(8.22f, 18f);
                randY = Random.Range(33.8f, 34.2f);
                randZ = Random.Range(129f, 134f);

                destPos = new Vector3(randX, randY, randZ);
                dir = destPos - transform.position;
                isArrived = false;
            }
            else
            {
                if (dir.magnitude < 2f)
                {
                    isArrived = true;
                }
                else
                {
                    dir = destPos - transform.position;
                    moveDistance = Mathf.Clamp(speed * Time.deltaTime, 0, dir.magnitude);
                    myRigid.MovePosition(transform.position + (dir.normalized * moveDistance));
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 3f * Time.deltaTime);
                    tempTime = 0;

                }
            }
        }
        animator.SetFloat("Movement", speed);

    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Contains("BossZone"))
        {
            isInBossZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("BossZone"))
        {
            isInBossZone = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            Vector3 tempDir = other.transform.position - transform.position;
            tempDir.Normalize();
            other.gameObject.GetComponent<Rigidbody>().AddForce(tempDir * 5f, ForceMode.Impulse);
        }
    }

    public void PushPlaer()
    {
        print("PushPlayer");
        Rigidbody playerRigid = player.GetComponent<Rigidbody>();
        playerRigid.AddForce(transform.forward * pushPower, ForceMode.Impulse);

    }


}
