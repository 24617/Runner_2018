using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour {

    public Text Timer;
    private float startTime;

	void Start () {
        startTime = Time.time;
	}

    void Update () {
        float T = Time.time - startTime;

        string minutes = ((int) T / 60).ToString();
        string seconds = (T % 60).ToString("f2");

        Timer.text = minutes + ":" + seconds;
		
	}
}
