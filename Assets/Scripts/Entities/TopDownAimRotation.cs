using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller;

    void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public  void OnAim(Vector2 Direction)
    {
        float rotZ = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90;
    }

   
}
