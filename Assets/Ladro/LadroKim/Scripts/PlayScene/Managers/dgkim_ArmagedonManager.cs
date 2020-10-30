using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class dgkim_ArmagedonManager : MonoBehaviour
{
    public GameObject armaPrefeb;

    Vector3 destination; // 바닥 착지지점
    Vector3 createPosition; // 상공 생성지점
    Vector3 dir; // 상공에서 바닥으로 향하는 방향

    int xRandom;
    int zRandom;

    float currentTime = 0;
    float spawnTime = 1.5f; 

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > spawnTime)
        {
            xRandom = Random.Range(-47, 15);
            zRandom = Random.Range(55, 113);

            destination = new Vector3(xRandom, 0, zRandom);

            createPosition = destination + new Vector3(60, 100, 0);

            GameObject arma = Instantiate(armaPrefeb);
            arma.transform.position = createPosition;

            arma.GetComponent<dgkim_Armageddon>().SetDestination(destination);

            currentTime = 0;
        }
    }

    public void KillPlayer()
    {
        GameObject player = GameObject.Find("Player");
        destination = player.transform.position;

        createPosition = destination + new Vector3(60, 143, 0);

        GameObject arma = Instantiate(armaPrefeb);
        arma.transform.position = createPosition;

        arma.GetComponent<dgkim_Armageddon>().SetDestination(destination);
    }



}
