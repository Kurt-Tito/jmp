using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject floor;
    public GameObject point;

    private float time_between_spawn;
    public float start_time_between_spawn;
    //public float decrease_time;
    //public float min_time = 0.65f;

    public float one_tile = 0.50f;
    public float two_tile = 0.75f;
	
	//Update is called once per frame
	void Update ()
    {
        int rand = Random.Range(1, 100);

        if (rand%2 == 0)
        {
            start_time_between_spawn = two_tile;
        }
        else
        {
            start_time_between_spawn = one_tile;
        }

		if (time_between_spawn <= 0)
        {
            Instantiate(floor, transform.position, Quaternion.identity);

            Vector3 pointPos = new Vector3(transform.position.x, transform.position.y + 2.5f, transform.position.z);
            Instantiate(point, pointPos, Quaternion.identity);

            time_between_spawn = start_time_between_spawn;
            
            //Slowly increases spawn rate whenever floor spawns
            /*
            if (start_time_between_spawn > min_time)
            {
                start_time_between_spawn -= decrease_time;
            }
            */
        }
        else
        {
            time_between_spawn -= Time.deltaTime;
        }
    }
}
