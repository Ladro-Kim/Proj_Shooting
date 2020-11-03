using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 처음 Trap1 트리거 On 되면 플레이어 추적

public class dgkim_Enemy : MonoBehaviour
{
    public GameObject target;
    float speed = 2f;

    bool isKilled = false;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!isKilled)
        {
            Vector3 dir = target.transform.position - transform.position;
            float distance = Mathf.Clamp(speed * Time.deltaTime, 0, dir.magnitude);

            transform.position += dir.normalized * distance;
            transform.LookAt(target.transform.position);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Player")
        {
            isKilled = true;
        }
    }

}
