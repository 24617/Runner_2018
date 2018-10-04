using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HearthCounter : MonoBehaviour {

    
    public Image[] hearts;
    public int NumberOfHearts = 5;
    public static int health = 5;
    public Color fullHeart;
    public Color emptyHeart;
	

	void Update () {

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].GetComponent<Image>().color = fullHeart;
            }
            else
            {
                hearts[i].GetComponent<Image>().color = emptyHeart;
            }
            if (i < NumberOfHearts)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health == 0)
        {

        }

    }
}
