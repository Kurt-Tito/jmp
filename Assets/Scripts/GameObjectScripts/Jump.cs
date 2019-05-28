using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1, 100)]
    public float jumpVelocity;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GetComponent<Rigidbody2D>().velocity.y);

        /*For Touch Controls */
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began && GetComponent<Rigidbody2D>().velocity.y == 0)
            {
                Debug.Log("JUMPED");
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;

                /* Plays Audio Source */
                GetComponent<AudioSource>().Play();
            }
        }

        /*For Keyboard Controls */
        if (Input.GetKeyDown(KeyCode.Space) && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            Debug.Log("JUMPED");
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;

            /* Plays Audio Source */
            GetComponent<AudioSource>().Play();
        }
        

        /*For Mouse Controls */
        /*-------------------------------------------------------------
        if (Input.GetButtonDown("Jump") && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            Debug.Log("JUMPED");
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
        */
    }
}
