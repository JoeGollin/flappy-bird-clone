using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBird : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private float SpriteYPos;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        SpriteYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        SpriteYPos = transform.position.y;
        if (SpriteYPos < 4.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                float jumpVelocity = 10f;
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
            }
        }

        if (SpriteYPos < -4)
        {
            print ("bird off screen");
        }
    }
}
