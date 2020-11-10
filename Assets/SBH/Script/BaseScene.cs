using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseScene : MonoBehaviour
{
    public Define.Scene sceneType = Define.Scene.Unknown;
    
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            SceneManager.LoadScene("NUM1(Fall)");
    }


}
