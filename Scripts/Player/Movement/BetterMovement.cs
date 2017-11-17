using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterMovement : MonoBehaviour
{
    static float defSpeed = 250.0f;
    float speed = defSpeed;
    float runSpeed = 300.0f;
    float turnSpeed = 150.0f;
    float jumpSpeed = 12.0f;
    public static bool inAir = false;

    int maxJumpTime = 25;
    int i = 25;

    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        rb.velocity = new Vector3(x, rb.velocity.y, z);

        var jump = Time.deltaTime * jumpSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = defSpeed;
        }
    }
}
