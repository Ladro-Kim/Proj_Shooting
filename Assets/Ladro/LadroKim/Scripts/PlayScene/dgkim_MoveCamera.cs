using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_MoveCamera : MonoBehaviour
{
    // GameObject player;
    public GameObject cameraPoint;
    float rX, rY;
    float rotSpeed = 200f;

    Vector3 playerPos = new Vector3(0, 3f, -5f);

    // Start is called before the first frame update
    void Start()
    {
        // player = GameObject.Find("hip");
    }

    private void Update()
    {
        // transform.position = player.transform.position + playerPos;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (Manager.manager.playerState == dgkim_Define.State.Arrive)
        {
            float xInput = Input.GetAxis("Mouse X");
            float yInput = Input.GetAxis("Mouse Y");

            // float scroll = Input.GetAxis("Mouse ScrollWheel");
            // print(scroll);

            rX += xInput * rotSpeed * Time.deltaTime;
            rY += yInput * rotSpeed * Time.deltaTime;

            rY = Mathf.Clamp(rY, -80, 80);

            cameraPoint.transform.eulerAngles = new Vector3(0, rX, 0);
            transform.eulerAngles = new Vector3(-rY, rX, 0);
        }
    }
}
