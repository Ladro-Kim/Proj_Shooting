using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dgkim_Trap3 : MonoBehaviour
{
    public GameObject trap3;
    // float speed = 3f;
    public GameObject trap3Trigger;

    public int index = 0;

    Vector3 destPos = new Vector3(-12.97f, 14.8f, 113.9f);

    private void Start()
    {
        trap3Trigger.SetActive(false);
    }

    private void Update()
    {
        if (index == 1)
        {
            trap3.transform.position = Vector3.Lerp(trap3.transform.position, destPos, 0.01f);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Player") || other.gameObject.name.Contains("hip") || other.gameObject.name.Contains("spine")
            || other.gameObject.name.Contains("RH") || other.gameObject.name.Contains("ra") || other.gameObject.name.Contains("ls")
            || other.gameObject.name.Contains("lt") || other.gameObject.name.Contains("ll") || other.gameObject.name.Contains("rs")
            || other.gameObject.name.Contains("rt") || other.gameObject.name.Contains("rl"))
        {
            print("player");
            trap3Trigger.SetActive(true);
            ParticleSystem ps = trap3Trigger.transform.Find("magic_ring_03").GetComponent<ParticleSystem>();
            ps.Stop();
            ps.Play();

            Manager.gameStage = dgkim_Define.Stage.Stage3;
        }
    }

}
