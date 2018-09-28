using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float[] Lanes;
    
    public int Lane = 0;
    bool StartGame = false;


    
    void Start () {
      
    }


    void Update() {

        if (Input.GetKeyDown("space"))
        {
            StartGame = true;
        }

        if (StartGame == true)
        {
            transform.position += Vector3.right * Time.deltaTime * 5;
            
        }
        
        transform.position = new Vector3(transform.position.x, transform.position.y, Lanes[Lane]);
        

        if (Input.GetKeyDown("up"))
        {
            if (Lane == 2 || Lane == 1 || Lane == 0)
            {
                Lane += 1;
               
            }
                
        }

        if (Input.GetKeyDown("down"))
        {
            if (Lane == 1 || Lane == 2 || Lane == 3)
            {
                Lane -= 1;
            }

        }

    }
}
