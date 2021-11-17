using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private Animator anim;
    private GameObject newInstance;
    public GameObject ball;
    public GameObject spawn;

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

    void BallEvent()
    {
        float instX = spawn.transform.position.x;
        float instY = spawn.transform.position.y;
        newInstance = Instantiate(ball, new Vector3(instX, instY, 0), Quaternion.identity);
    }
}
