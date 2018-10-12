using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public float myScore = 0;


    Player player;

    float tijd = 1;

    public Text Score;

    void Start()
    {

        player = GameObject.Find("Player").GetComponent<Player>();

        Score.text = "";
        print("Start van score");
        
    }

    public void Save(Player player)
    {
        Debug.Log("hola chicos");
      if (player.die == true)
        {
            Debug.Log("je hebt ons opgeslagen honey");
            saveLoad.SaveData(this);
            SceneManager.LoadScene("deathScreen");
        }
    }

    void Update()
    {
        Save(player);
        
        print(player.die);


        AddScore(Time.deltaTime * 2);
    }

    public void AddScore(float add)
    {
        myScore += add;
        Score.text = "Score: " + Mathf.FloorToInt(myScore).ToString();
    }
}
