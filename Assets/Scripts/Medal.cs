using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour {

    public Text endScore;

    public Sprite noMedal;
    public Sprite bronze;
    public Sprite silver;
    public Sprite gold;
    public Sprite platinum;
    public Sprite diamond;

    private Image medal;

	// Use this for initialization
	void Start ()
    {
        medal = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (int.Parse(endScore.text) < 25)
            medal.sprite = noMedal;
        if (int.Parse(endScore.text) >= 25 && int.Parse(endScore.text) < 50)
        {
            medal.sprite = bronze;
            PlayerPrefs.SetInt("BRONZE", 1);
        }
        if (int.Parse(endScore.text) >= 50 && int.Parse(endScore.text) < 75)
        {
            medal.sprite = silver;
            PlayerPrefs.SetInt("SILVER", 1);
        }
        if (int.Parse(endScore.text) >= 75 && int.Parse(endScore.text) < 100)
        {
            medal.sprite = gold;
            PlayerPrefs.SetInt("GOLD", 1);
        }
        if (int.Parse(endScore.text) >= 100 && int.Parse(endScore.text) < 200)
        {
            medal.sprite = platinum;
            PlayerPrefs.SetInt("PLATINUM", 1);
        }
        if (int.Parse(endScore.text) >= 200)
        {
            medal.sprite = diamond;
            PlayerPrefs.SetInt("DIAMOND", 1);
        }



    }
}
