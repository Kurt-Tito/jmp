using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.Advertisements;

public class PlayerDestroyer : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject taptoplayagain;

    private bool isGameOver = false;

    public GameObject EarnedMedalsPanel;
    private bool isEarnedMedalPanel = false;

    public static int adCount = 0; 

    void Start()
    {
        AddPoint.newBest = false;
    }

    void FixedUpdate()
    {
        if (isGameOver)
        {
            /*For Touch Controls */
            //  For restarting the game
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began && !isEarnedMedalPanel)
                {
                    isEarnedMedalPanel = true;
                    EarnedMedalsPanel.SetActive(true);
                }
                else if (touch.phase == TouchPhase.Began && isEarnedMedalPanel)
                {
                    /* INSERT AD UNIT HERE */
                    //
                    //

                    if (Advertisement.IsReady() && adCount == 5)
                    {
                        Advertisement.Show("video");
                        adCount = 0;
                    }
                    else
                    {
                        SceneManager.LoadScene("GameJump");
                        AddPoint.playerScore = 0;
                    }

                    //SceneManager.LoadScene("GameJump");
                    //AddPoint.playerScore = 0;
                }
            }

            /*For Keyboard Controls */
            /*
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("GameJump");
                AddPoint.playerScore = 0;
            }
            */
        }
    }

    /* 
    void Update()
    {
        if (isGameOver)
        {
            //For Touch Controls 
            //  For restarting the game
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    isEarnedMedalPanel = true;
                    EarnedMedalsPanel.SetActive(true);
                }
                else if (touch.phase == TouchPhase.Began && isEarnedMedalPanel)
                {
                    SceneManager.LoadScene("GameJump");
                    AddPoint.playerScore = 0;
                }
            }

            //For Keyboard Controls //
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("GameJump");
                AddPoint.playerScore = 0;
            }
        }
    } 
    */

	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
            gameOver.SetActive(true);
            taptoplayagain.SetActive(true);
            isGameOver = true;

            adCount++;
        }
    }
}
