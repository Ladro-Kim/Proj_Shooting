using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 처음 Trap1 트리거 On 되면 플레이어 추적

public class dgkim_Enemy : MonoBehaviour
{
    public GameObject target;
    float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.transform.position - transform.position;
        dir.Normalize();

        transform.position += dir * speed * Time.deltaTime;
        transform.LookAt(target.transform.position);
    }

    void OnCollisionEnter(Collision other)
    {
        
        if(other.gameObject.name == "Player")
        {
            other.gameObject.SetActive(false);
        }
    }
}
