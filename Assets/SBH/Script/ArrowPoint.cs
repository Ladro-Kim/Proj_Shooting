using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPoint : MonoBehaviour
{

    [SerializeField]
    public Transform Target1;
    public Transform Target2;
    public Transform Target3;
    public Transform Target4;

    Transform destPos;

    private void Update()
    {
        switch (Manager.gameStage)
        {
            case dgkim_Define.Stage.Stage1:
                destPos = Target1;
                break;
            case dgkim_Define.Stage.Stage2:
                destPos = Target2;
                break;
            case dgkim_Define.Stage.Stage3:
                destPos = Target3;
                break;
            case dgkim_Define.Stage.Stage4:
                destPos = Target4;
                break;
        }

        Vector3 dir = destPos.position - transform.position;
        dir.Normalize();
        // transform.LookAt(destPos.position);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 0.05f * Time.time);

    }
}
