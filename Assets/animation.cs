using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{

    public Animator animator;
    void Start()
    {

        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
            animator.Play("Run",-1,0f);
        if (Input.GetKeyDown("2"))
            animator.Play("Walk", -1, 0f);
        if (Input.GetKeyDown("3"))
            animator.Play("Taunt", -1, 0f);
        if (Input.GetKeyDown("4"))
            animator.Play("Idle", -1, 0f);
        if (Input.GetMouseButtonDown(0))
        {
            int n = Random.Range(0, 3);
            if (n == 0)
            {
                animator.Play("Attack1", -1, 0f);
            }
            else if (n == 1)
            {
                animator.Play("Attack2", -1, 0f);
            }
            else
            {
                animator.Play("Attack3", -1, 0f);
            }
        }
    }
}
        

