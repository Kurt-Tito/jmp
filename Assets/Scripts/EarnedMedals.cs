using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarnedMedals : MonoBehaviour {

    public GameObject earnedMedals;
    public GameObject showMedals;
    //public GameObject showScore;

    public static bool buttonPressed;

    // Use this for initialization
    void Start () {
        buttonPressed = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void showEarnedMedalsPanel()
    {
        earnedMedals.SetActive(true);
        showMedals.SetActive(false);
        //showScore.SetActive(true);
        buttonPressed = true;

    }

    public void showScorePanel()
    {
        earnedMedals.SetActive(false);
        showMedals.SetActive(true);
       // showScore.SetActive(false);
        buttonPressed = true;
    }
}
