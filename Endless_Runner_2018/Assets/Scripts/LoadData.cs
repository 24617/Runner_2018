using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour {


    score ScoreT;
    float endScore;

    public Text Score;

    public void Load (score ScoreT) {

        float[] loadedScore = saveLoad.LoadData();
        print(loadedScore[0]);
        endScore = loadedScore[0];

        Score.text = "End Score = " + Mathf.FloorToInt(endScore).ToString();
       
    }

    void Start()
    {
        Debug.Log("LADEN");
        Load(ScoreT);
    }
}
