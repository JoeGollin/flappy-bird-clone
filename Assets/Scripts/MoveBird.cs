using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveBird : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private float spriteYPos;
    public int playerScore;
    public int displayScore;
    public Text scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        spriteYPos = transform.position.y;
        playerScore = 0;
        displayScore = 0;
        StartCoroutine(ScoreUpdater());

    }

    // Update is called once per frame
    void Update()
    {
        Mathf.FloorToInt(Time.timeSinceLevelLoad);

        spriteYPos = transform.position.y;
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
            print ("bird off screen");
        }
    }

    private IEnumerator ScoreUpdater()
    {
        while (true)
        {
            if (displayScore < playerScore)
            {
                displayScore++;
                scoreUI.text = displayScore.ToString();
            }
            yield return new WaitForSeconds(0.2f);
        }
        
    }
}
