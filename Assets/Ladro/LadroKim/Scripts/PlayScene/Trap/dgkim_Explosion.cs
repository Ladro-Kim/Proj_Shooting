using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Explosion : MonoBehaviour
{
    GameObject player;

    void Start()
    {

    }

    void Update()
    {
        // StartCoroutine("ieCameraPunch");
    }

    IEnumerator ieCameraPunch()
    {
        Vector3 origin = Camera.main.transform.position;
        for (int i = 0; i < 10; i++)
        {
            Camera.main.transform.position = origin + Random.insideUnitSphere * 0.1f;
            yield return new WaitForSeconds(0.1f);
        }

        Camera.main.transform.position = origin;
    }

}
