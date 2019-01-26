using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D characterRigidBody;
    public float speed = 3f;
    Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        characterRigidBody.velocity = new Vector2(0,0);
        velocity = characterRigidBody.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.y = 0f;
            characterRigidBody.velocity = velocity;
            //Yes, apparently this whole step is necessary.
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.y = speed;
            characterRigidBody.velocity = velocity;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.y = -speed;
            characterRigidBody.velocity = velocity;
        }
        else
        {
            velocity = characterRigidBody.velocity;
            velocity.y = 0f;
            characterRigidBody.velocity = velocity;
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.x = 0f;
            characterRigidBody.velocity = velocity;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.x = speed;
            characterRigidBody.velocity = velocity;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.x = -speed;
            characterRigidBody.velocity = velocity;
        }
        else
        {
            velocity = characterRigidBody.velocity;
            velocity.x = 0f;
            characterRigidBody.velocity = velocity;
        }
    }
}
