﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {


    public static float speed;
	
	// Update is called once per frame
	void Update ()
    {

        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}
}
