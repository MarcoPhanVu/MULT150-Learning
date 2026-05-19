using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("color");
        } else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("scale");
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("rotate");
        } else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("move");
        }
    }
}
