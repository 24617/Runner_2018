using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    

	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Wall")
        {
            Destroy(gameObject);
            
        }
    }
}

