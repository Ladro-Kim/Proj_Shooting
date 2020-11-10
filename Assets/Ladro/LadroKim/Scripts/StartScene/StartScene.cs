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
<<<<<<< HEAD
    PressShiftKey,
    PressJumpKey,
=======
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
    StartButton
}

public class StartScene : MonoBehaviour
{
    public Text _constructionText;
    public InputField _inputField;

    public GameObject login;
    public Image _image;

    Stage _stage = Stage.PressAnyKey;

<<<<<<< HEAD
    bool isW, isS, isA, isD, isShift;
=======
    bool isW, isS, isA, isD;
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1

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
<<<<<<< HEAD
                _constructionText.text = "Press any key";
                if (Input.anyKey)
                {
=======
                if (Input.anyKey)
                {
                    _constructionText.text = "Press A, S, D, F to move your character.";
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
                    _stage = Stage.PressDirectionKey;
                }
                else
                {
                    return;
                }
                break;
            case Stage.PressDirectionKey:
<<<<<<< HEAD
                _constructionText.text = "Press A, S, D, F to move your character.";
                CheckKeyInput();
                if (isW && isS && isA && isD)
                {
                    _stage = Stage.PressShiftKey;
                    isW = isS = isA = isD = false;

                }
                else
                {
                    return;
                }
                break;
            case Stage.PressShiftKey:
                _constructionText.text = "To move faster, Press A, S, D, F with Left shift key.";
                CheckKeyInput();
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    isShift = true;
                }
                else
                {
                    return;
                }
                if (isW && isS && isA && isD && isShift)
                {
                    _stage = Stage.PressJumpKey;

                }
                break;
            case Stage.PressJumpKey:
                _constructionText.text = "To jump, Press Space Bar";
                if (Input.GetKey(KeyCode.Space))
                {
                    _stage = Stage.StartButton;
                }
=======
                CheckKeyInput();
>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
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
<<<<<<< HEAD
=======

        if (isW && isS && isA && isD)
        {
            _stage = Stage.StartButton;
        }

>>>>>>> d4f3da60a3bc4b79bdd148eb6bd62b7158e4c4c1
    }




}
