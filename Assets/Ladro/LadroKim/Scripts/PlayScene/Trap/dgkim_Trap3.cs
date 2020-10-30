using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap3 : MonoBehaviour
{
    public GameObject trap3;
    // float speed = 3f;
    public GameObject trap3Trigger;

    public int index = 0;

    Vector3 destPos = new Vector3(-12.97f, 14.8f, 113.9f);

    private void Update()
    {
        if (index == 1)
        {
            trap3.transform.position = Vector3.Lerp(trap3.transform.position, destPos, 0.01f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player"))
        {
            trap3Trigger.SetActive(true);
        }
    }

}
