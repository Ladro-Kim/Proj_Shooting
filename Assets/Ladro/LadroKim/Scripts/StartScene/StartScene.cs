using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum Stage
{
    PressAnyKey,
    PressDirectionKey,
    StartButton
}

public class StartScene : MonoBehaviour
{
    public Text _constructionText;
    public InputField _inputField;

    public GameObject login;
    public Image _image;

    Stage _stage = Stage.PressAnyKey;

    bool isW, isS, isA, isD;

    // Start is called before the first frame update
    void Start()
    {
        login.SetActive(false);
        // originColor = renderer.material.GetColor("_")
    }

    // Update is called once per frame
    void Update()
    {
        switch (_stage)
        {
            case Stage.PressAnyKey:
                if (Input.anyKey)
                {
                    _constructionText.text = "Press A, S, D, F to move your character.";
                    _stage = Stage.PressDirectionKey;
                }
                else
                {
                    return;
                }
                break;
            case Stage.PressDirectionKey:
                CheckKeyInput();
                break;
            case Stage.StartButton:
                _constructionText.text = "Input your ID and press start button";
                login.SetActive(true);
                break;
        }

    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene("Play");
    }


    public void CheckKeyInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isW = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            isS = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            isA = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            isD = true;
        }

        if (isW && isS && isA && isD)
        {
            _stage = Stage.StartButton;
        }

    }




}
