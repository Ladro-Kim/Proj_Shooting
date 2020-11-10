using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody rb;
    public CapsuleCollider caps;
    public HingeJoint[] mortejoint;
    bool fall = false;
    [Space(20)]
    public CapsuleCollider colicap;

    public HingeJoint hj1, hj2;
    public JointSpring hs1, hs2;
    public float Springmin = 30, Springmax = 300;

    [Space(20)]
    public float Resistance = 10;
    public Animator Anim;
    public float velocidade;

    enum State
    {
        섬,
        넘어짐,
        일어남,

    }
    State Morto = State.섬;

    [Space(20)]
    public bool AtivarAutoConserto;
    public Transform checkRootable;
    public bool Corrigindo;
    public float MinRoot, MaxRoot;
    public float Inclinacao;
    private bool prefeicao;
    private float pretime;
    bool isGrounded;
    private float jumpaccount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > Resistance)
        {
            Morto = State.넘어짐;

        }

  
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > Resistance)
        {
            caps.enabled = false;
            rb.constraints = RigidbodyConstraints.None;
            Anim.SetBool("IsRun", true);
            fall = true;
            StartCoroutine(Out());
        }

      if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            jumpaccount = 0;
        }

    }

    float Velocity = 10;
    void _Jump()
    {
        //if (!fall)
        //{
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, Velocity * 100, 0), ForceMode.Impulse);
            Debug.Log("JUMP!");
        }
        // }
    }
    void Start()
    {
        velocidade = GetComponent<Rigidbody>().velocity.magnitude;
        rb = GetComponent<Rigidbody>();
        caps = GetComponent<CapsuleCollider>();
        prefeicao = true;
        jumpaccount = 0;
        hs1 = hj1.spring;
        hs2 = hj2.spring;
    }

    IEnumerator Out()
    {
        rb.constraints = RigidbodyConstraints.None;
        caps.enabled = false;
        yield return new WaitForSeconds(1);
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        caps.enabled = false;

        Morto = State.섬;
    }

    void Update()
    {
        if (Manager.manager.playerState == dgkim_Define.State.Arrive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, Velocity * 150, 0), ForceMode.Impulse);
            }

            if (Morto == State.넘어짐)
            {
                // 넘어진 상태
                // 키를 누르면 일으키자.
                if (Input.anyKeyDown)
                {
                    Morto = State.일어남;
                    StartCoroutine(Out());
                }
            }
            else if (Morto == State.섬)
            {
                // 넘어지지 않은 상태
                if (Input.GetKey(KeyCode.W))
                {
                    rb.AddForce(transform.forward * 2f, ForceMode.Impulse);
                    Anim.SetBool("IsRun", false);
                    hs1.spring = Springmin;
                    hs2.spring = Springmin;
                    if (Input.GetKey(KeyCode.A))
                    {
                        transform.Rotate(0, -120 * Time.deltaTime, 0);
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        transform.Rotate(0, 120 * Time.deltaTime, 0);
                    }
                }

                if (Input.GetKey(KeyCode.W) == false && Corrigindo == false)
                {
                    Anim.SetBool("IsRun", true);
                    hs1.spring = Springmax;
                    hs2.spring = Springmax;
                }
                if (Input.GetKey(KeyCode.S))
                {

                }
                if (Input.GetKey(KeyCode.A))
                {

                }
                if (Input.GetKey(KeyCode.D))
                {

                }
            }
        }
        else
        {
            print("Dead");
        }
    }
}

