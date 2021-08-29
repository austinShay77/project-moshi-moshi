using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D body;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Left = -1, Right = 1
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        //Movement
        body.MovePosition(body.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
