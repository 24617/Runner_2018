using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float myScore = 0;

   
    

    float tijd = 1f;

    public Text Score;

    void Start()
    {
        
    Score.text = "";

        
    }

    public void Save(Player player)
    {
      if (player.die == true)
        {
            Debug.Log("je hebt ons opgeslagen honey");
            saveLoad.SaveData(this);
           
        }
    }

    void Update()
    {

       


        AddScore(Time.deltaTime);
    }

    public void AddScore(float add)
    {
        myScore += add;
        Score.text = "Score: " + Mathf.FloorToInt(myScore).ToString();
    }
}
