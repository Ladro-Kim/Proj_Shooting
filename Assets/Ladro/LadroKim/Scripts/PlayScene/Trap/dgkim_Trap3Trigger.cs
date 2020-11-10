using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap3Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        if(other.gameObject.name.Contains("Trap3"))
        {
            other.gameObject.GetComponent<dgkim_Trap3>().index = 1;
            gameObject.SetActive(false);
            Manager.gameStage = dgkim_Define.Stage.Stage4;
        }
    }
}
