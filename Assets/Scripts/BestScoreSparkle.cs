using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreSparkle : MonoBehaviour {

    private Image img;
    public Sprite sparkle;
    //public Sprite empty;

	// Use this for initialization
	void Start ()
    {
        img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (AddPoint.newBest == true)
        {
            img.sprite = sparkle;
        }
        else
        {
            img.enabled = false;
        }
	}
}
