using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{

    private static int score;
    public Text scoreText;

    private void Update()
    {
        score = AddPoint.playerScore;
        scoreText.text = score.ToString("00");
    }

    /*
	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Point")
        {
            score++;
        }
    }
    */
}
