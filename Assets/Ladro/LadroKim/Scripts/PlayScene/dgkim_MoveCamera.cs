using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_MoveCamera : MonoBehaviour
{
    float rX, rY;
    float rotSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");

        // float scroll = Input.GetAxis("Mouse ScrollWheel");
        // print(scroll);

        print($"{rX} / {rY}");

        rX += xInput * rotSpeed * Time.deltaTime;
        rY += yInput * rotSpeed * Time.deltaTime;

        rY = Mathf.Clamp(rY, -80, 80);

        transform.eulerAngles = new Vector3(-rY, rX, 0);

    }
}
