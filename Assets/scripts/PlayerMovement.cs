using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1;
    public float jumpForce = 1;

    public Animator animator;

    private Rigidbody2D myRigidBody2D;

    float horizontalMove = 0f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * speed;

        animator.SetFloat("speed", horizontalMove);

        if (Input.GetButtonDown("Jump") && myRigidBody2D.velocity.y < 0.7f && myRigidBody2D.velocity.y > -0.7f)
        {
            myRigidBody2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

    }
}
