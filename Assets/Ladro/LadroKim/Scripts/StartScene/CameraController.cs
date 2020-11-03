using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // public float _mouseSpeed = 200f;
    public GameObject player;

    Vector3 dir = new Vector3(0, 8, -9);

    // float mX, mY;

    void Start()
    {
        
    }

    void Update()
    {

        //float x = Input.GetAxis("Mouse X");
        //float y = Input.GetAxis("Mouse Y");

        //mX += x * _mouseSpeed * Time.deltaTime;
        //mY += y * _mouseSpeed * Time.deltaTime;

        //mY = Mathf.Clamp(mY, -90, 90);

        //transform.eulerAngles = new Vector3(-mY, mX, 0);

    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + dir;
    }
}
