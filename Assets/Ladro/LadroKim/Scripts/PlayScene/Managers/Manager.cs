using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    static Manager _instance;
    public static Manager manager { get { Init(); return _instance; } }

    public dgkim_Define.State playerState;
    public static dgkim_Define.Stage gameStage;

    public GameObject Stage2;
    public GameObject Stage3;

    // Start is called before the first frame update
    void OnEnable()
    {
        Init();
        playerState = dgkim_Define.State.Arrive;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameStage)
        {
            case dgkim_Define.Stage.Stage1:
                Stage2.SetActive(false);
                Stage3.SetActive(false);
                break;
            case dgkim_Define.Stage.Stage2:
                Stage2.SetActive(true);
                break;
            case dgkim_Define.Stage.Stage4:
                Stage3.SetActive(true);
                break;
        }
    }

    static void Init()
    {
        GameObject go = GameObject.Find("@Manager");
        //if (go == null)
        //{
        //    go = new GameObject { name = "@Manager" };
        //    go.AddComponent<Manager>();
        //}
        _instance = go.GetComponent<Manager>();
    }

}
