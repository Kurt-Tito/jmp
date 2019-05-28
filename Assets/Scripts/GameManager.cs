using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startfloor;
    public GameObject floor;
    public GameObject spawner;
    public GameObject playerScore;
    public GameObject jmpLabel;

    public GameObject taptostart;

    private bool lockSpeed;

    public Animator anim;

    public GameObject bronze;
    public GameObject silver;
    public GameObject gold;
    public GameObject platinum;
    public GameObject diamond;

    // Use this for initialization
    void Start ()
    {
        lockSpeed = false;
    
        Obstacle.speed = 0;
        Time.timeScale = 1.0f;
        spawner.GetComponent<Spawner>().enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*For Touch Controls */
        //  Starts the game
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (!lockSpeed)
                {
                    Obstacle.speed = 8;
                }

                lockSpeed = true;
                spawner.GetComponent<Spawner>().enabled = true;

                taptostart.SetActive(false);
                jmpLabel.SetActive(false);
                playerScore.SetActive(true);
            }
        }

        /*For Keyboard Controls */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!lockSpeed)
            {
                Obstacle.speed = 8;
            }

            lockSpeed = true;
            spawner.GetComponent<Spawner>().enabled = true;

            taptostart.SetActive(false);
            jmpLabel.SetActive(false);
            playerScore.SetActive(true);
        }

        if (AddPoint.playerScore == 50)
        {
            //Obstacle.speed = 9;

            /* The Scale at which time is passing. */
            Time.timeScale = 1.1f;
        }
        else if (AddPoint.playerScore == 100)
        {
            /* The Scale at which time is passing. */
            Time.timeScale = 1.15f;
        }
        else if (AddPoint.playerScore == 150)
        {
            /* The Scale at which time is passing. */
            Time.timeScale = 1.2f;
        }
        else if (AddPoint.playerScore == 175)
        {
            /* The Scale at which time is passing. */
            Time.timeScale = 1.25f;
        }
        else if (AddPoint.playerScore == 200)
        {
            /* The Scale at which time is passing. */
            Time.timeScale = 1.3f;
        }
        //else if (AddPoint.playerScore == 125)
        //{
            /* The Scale at which time is passing. */
            //Time.timeScale = 1.35f;
        //}
        //else if (AddPoint.playerScore == 150)
        //{
            /* The Scale at which time is passing. */
            //Time.timeScale = 1.4f;
        //}
        //else if (AddPoint.playerScore == 200)
        //{
            /* The Scale at which time is passing. */
            //Time.timeScale = 1.45f;
        //}

        if (Obstacle.speed > 0)
        {
            if (anim != null)
                anim.SetFloat("obstacle_speed", 2f);
        }

        if (PlayerPrefs.GetInt("BRONZE", 0) == 1)
        {
            bronze.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SILVER", 0) == 1)
        {
            silver.SetActive(true);
        }
        if (PlayerPrefs.GetInt("GOLD", 0) == 1)
        {
            gold.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PLATINUM", 0) == 1)
        {
            platinum.SetActive(true);
        }
        if (PlayerPrefs.GetInt("DIAMOND", 0) == 1)
        {
            diamond.SetActive(true);
        }
    }
}
