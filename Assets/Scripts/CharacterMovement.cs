using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D characterRigidBody;
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
        if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.y = 0f;
            characterRigidBody.velocity = velocity;
            //Yes, apparently this whole step is necessary.
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.y = 3f;
            characterRigidBody.velocity = velocity;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.y = -3f;
            characterRigidBody.velocity = velocity;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.x = 0f;
            characterRigidBody.velocity = velocity;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.x = 3f;
            characterRigidBody.velocity = velocity;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            velocity = characterRigidBody.velocity;
            velocity.x = -3f;
            characterRigidBody.velocity = velocity;
        }
    }
}
