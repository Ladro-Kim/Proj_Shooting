using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gameComplete;
    
    Manager manager;
    public Text timerText;
    public Text bestText;
    public Text completeText;
    float timer;
    float bestScore;

    // Start is called before the first frame update
    void Start()
    {
        //playerState = GameObject.Find("hip").GetComponent<dgkim_MoveToUp>();
        bestScore = PlayerPrefs.GetFloat("Best", 0);
        if (bestScore == 0)
        {
            bestText.text = $"Record : No record.";
        }
        else
        {
            bestText.text = $"Record : {bestScore.ToString("N2")}";
        }

    }

    // Update is called once per frame
    void Update()
    {
        switch (Manager.manager.playerState)
        {
            case dgkim_Define.State.Dead:
                gameOverUI.SetActive(true);
                break;
            case dgkim_Define.State.Arrive:
                timer += Time.deltaTime;
                timerText.text = ($"Time : {timer.ToString("N2")}");
                break;
            case dgkim_Define.State.Finish:
                if (timer < bestScore)
                {
                    bestScore = timer;
                    bestText.text = $"Recored : {bestScore.ToString("N2")}";
                    PlayerPrefs.SetFloat("Best", bestScore);
                }
                gameComplete.SetActive(true);
                PlayerPrefs.GetFloat("Best", bestScore);
                if (bestScore == 0)
                {
                    completeText.text = $"Your time : {timer.ToString("N2")} \n Best time : No record";
                }
                else
                {
                    completeText.text = $"Your time : {timer.ToString("N2")} \n Best time : {bestScore.ToString("N2")}";
                }

                break;
        }
    }
}
