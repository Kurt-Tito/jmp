using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoint : MonoBehaviour {

    public static int playerScore = 0;
    public static bool newBest;

    private BoxCollider2D collision;

    void Start()
    {
        collision = GetComponent<BoxCollider2D>();
    }

	void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("COLLISION DETECTED");

            playerScore++;
            Debug.Log("Score: " + playerScore);

            /* STORES HIGHSCORE DATA */
            if (playerScore > PlayerPrefs.GetInt("BESTSCORE", 0))
            {
                //TODO: SET BOOLEAN FOR ANIMATING BEATING BEST SCORE
                //BOOL newBest = false;
                //if (newBest)
                //  SPARKLE BESTSCORE NUMBER

                /* Plays High Score SFX */
                if (!newBest)
                    GetComponent<AudioSource>().Play();

                newBest = true;
                PlayerPrefs.SetInt("BESTSCORE", playerScore);
            }

            collision.enabled = false;
        }
    }
}
