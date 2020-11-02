using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float _keySpeed = 5;


    void Start()
    {

    }

    void Update()
    {
        InputKey();
    }

    public void InputKey()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0f, z);
        dir.Normalize();

        transform.position += dir * _keySpeed * Time.deltaTime;
    }




}
