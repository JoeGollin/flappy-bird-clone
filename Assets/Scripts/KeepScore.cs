using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepScore : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasePerSecond;


    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        pointIncreasePerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += pointIncreasePerSecond * Time.deltaTime;
    }
}
