using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    private Text bestScore;

	// Use this for initialization
	void Start ()
    {
        bestScore = GetComponent<Text>();
        bestScore.text = PlayerPrefs.GetInt("BESTSCORE", 0).ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
