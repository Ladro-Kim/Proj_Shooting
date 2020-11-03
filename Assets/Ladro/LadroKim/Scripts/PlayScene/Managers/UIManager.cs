using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    dgkim_MovePlayer playerState;

    public Text timerText;
    public Text bestText;
    float timer;
    float bestScore;

    // Start is called before the first frame update
    void Start()
    {
        playerState = GameObject.Find("Player").GetComponent<dgkim_MovePlayer>();
        bestScore = PlayerPrefs.GetFloat("Best", 0);
        bestText.text = $"Record : {bestScore.ToString("N2")}"; 
    }

    // Update is called once per frame
    void Update()
    {
        if (playerState.isDead)
        {

        }
        else
        {
            timer += Time.deltaTime;
            timerText.text = ($"Time : {timer.ToString("N2")}");

            if (timer > bestScore)
            {
                bestScore = timer;
                bestText.text = $"Recored : {bestScore.ToString("N2")}";
                PlayerPrefs.SetFloat("Best", bestScore);
            }
        }
    }


}
