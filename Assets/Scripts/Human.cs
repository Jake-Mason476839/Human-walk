using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("Throw", false);
        anim.SetBool("Walk", false);

        if (Input.GetKey(KeyCode.Q))
        {
            anim.SetBool("Throw", true);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Walk", true);
        }

    }
}
