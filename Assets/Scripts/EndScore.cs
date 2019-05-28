using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

    private Text endScore;
  
	// Use this for initialization
	void Start ()
    {
        endScore = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        endScore.text = AddPoint.playerScore.ToString("00");
	}
}
