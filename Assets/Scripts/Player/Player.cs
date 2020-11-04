using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletonMonobehaviour<Player>
{
    // Movement Parameters
    private float xInput;

    private float yInput;
    private Camera mainCamera;
    private Rigidbody2D rigidBody2D;
    private Direction playerDirection;
    private float movementSpeed;

    protected override void Awake()
    {
        base.Awake();

        rigidBody2D = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }
}
