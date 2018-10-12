using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform Player;
	
	void LateUpdate () {
        transform.position = new Vector3(Player.position.x + 6,transform.position.y,transform.position.z);
	}
}
