using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBird : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private float spriteYPos;
    private float spriteXPos;
    public AudioClip coinAudio;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        spriteYPos = transform.position.y;
        spriteXPos = transform.position.x;
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Mathf.FloorToInt(Time.timeSinceLevelLoad);
        spriteYPos = transform.position.y;
        spriteXPos = transform.position.x;

        if (spriteYPos < 4.5)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                float jumpVelocity = 8f;
                rigidbody2d.velocity = Vector2.up * jumpVelocity;
            }
        }

        if (spriteYPos < -4)
        {
            print ("bird off bottom screen");
        }

        if (spriteXPos < -8)
        {
            print("Bird off left of screen");
        }
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CoinPrefab(Clone)")
        {
            print("Collision Detected With Coin");
            Destroy(collision.gameObject);
            KeepScore scoreScript = GetComponent<KeepScore>();
            scoreScript.scoreAmount += 10;
            audioSource.PlayOneShot(coinAudio, 0.5f);
            
        }
    }

}
