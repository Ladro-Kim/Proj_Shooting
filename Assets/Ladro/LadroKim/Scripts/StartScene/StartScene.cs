using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public Canvas canvas;
    public Text text;
    public MeshRenderer renderer;

    Color originColor;
    Color nextColor;
    
    int stage;

    // Start is called before the first frame update
    void Start()
    {
        // originColor = renderer.material.GetColor("_")
        stage = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }





}
