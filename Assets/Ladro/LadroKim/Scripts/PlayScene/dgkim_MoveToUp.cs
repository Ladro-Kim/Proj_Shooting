using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_MoveToUp : MonoBehaviour
{
    public GameObject gameOverUI;

    private void Start()
    {
        // gameOverUI = GameObject.Find("GameOver");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("Barrel"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name.Contains("hip"))
        {
            Manager.manager.playerState = dgkim_Define.State.Dead;
        }
    }

}
