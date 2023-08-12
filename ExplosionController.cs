using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    private Animator animator;
    public bool explode;

    private void Start()
    {
        // Access the animator
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // If the explosion is triggered
        if (explode == true)
        {
            // Explode
            animator.SetBool("playerGuessed", true);
        }
        else
        {
            // Set to un-exploded state
            animator.SetBool("playerGuessed", false);
        }
    }
}
