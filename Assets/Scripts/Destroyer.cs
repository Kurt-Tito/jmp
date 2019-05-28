using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    /*
    public float lifetime;

	private void Start ()
    {
        Destroy(gameObject, lifetime);
	}
    */

    void OnCollisionEbter2D(Collision2D col)
    {
        Debug.Log("COLLIDED");

        if (col.gameObject.name == "StartFloor")
        {
            Debug.Log("COLLIDED");

            Debug.Log("Collision name = " + col.gameObject.name);
            Destroy(col.gameObject);
        }
    }
	
}
