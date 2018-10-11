using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour {

    
    public Text Score;
    private void Start()
    {
        
    }
    // Use this for initialization
    void load (score Score) {


        float[] loadedScore = saveLoad.LoadData();
        Score.myScore = loadedScore[0];
        this.Score.text = "End Score = " + Score;


    }

	// Update is called once per frame
	void Update () {

        

    }
}
