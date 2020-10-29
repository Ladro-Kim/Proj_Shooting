using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Return : MonoBehaviour
{
    // int is
    public GameObject startPoint;

    int index = 0;
    float currentTIme = 0;
    float repeatTime = 8;
    public GameObject[] circlePrefebs;
    GameObject blue;
    GameObject red;

    private void Start()
    {
        blue = GameObject.Instantiate(circlePrefebs[0]);
        blue.transform.position = transform.position;
        red = GameObject.Instantiate(circlePrefebs[1]);
        red.transform.position = transform.position;
    }

    private void Update()
    {
        currentTIme += Time.deltaTime;
        
        if(currentTIme < repeatTime / 2)
        {
            index = 0;
            blue.SetActive(true);
            red.SetActive(false);

        }
        else if (currentTIme <= repeatTime)
        {
            index = 1;
            blue.SetActive(false);
            red.SetActive(true);
        }
        else
        {
            currentTIme = 0;
        }

    }

    void OnCollisionStay(Collision other)
    {
        if (index == 1)
        {
            other.transform.position = startPoint.transform.position;
        }
    }
}
