using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("hip"))
        {
            Manager.manager.playerState = dgkim_Define.State.Dead;
        }

    }

}
