using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Play(44100);
    }

    private void Update()
    {
        if (Manager.manager.playerState == dgkim_Define.State.Dead || Manager.manager.playerState == dgkim_Define.State.Finish)
        {
            for (float i = 1; i >0; i -= 0.1f)
            {
                audiosource.volume -= 0.1f * Time.deltaTime;
            }
        }
    }
}
