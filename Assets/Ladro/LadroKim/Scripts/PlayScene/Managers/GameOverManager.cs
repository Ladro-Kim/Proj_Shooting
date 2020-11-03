using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{

    public Button btn_restart;
    public Button btn_exit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRestartClicked()
    {
        SceneManager.LoadScene("Play");
    }

    public void OnExitClicked()
    {
        Application.Quit();
    }

}
