using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAinmationController : TopDownAinmations
{
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += animation;
    }

    public void animation(Vector2 direction)
    {
        animator.SetBool("IsWalking", direction.magnitude > 0f);
    }

}
