using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap1 : MonoBehaviour
{

    public GameObject pref_trap;
    float currentTime = 0;
    float spawnTime = 2;
    bool isPlayer = false;

    // Update is called once per frame
    void Update()
    {
        if(isPlayer == true)
        {
            currentTime += Time.deltaTime;
            print(currentTime);
            if (currentTime >= spawnTime)
            {
                GameObject trap = Instantiate(pref_trap);
                trap.transform.position = transform.position;
                currentTime = 0;
                isPlayer = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isPlayer = true;
        }
    }

}
