using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HearthCounter : MonoBehaviour {

    public Image[] hearts;
    public int NumberOfHearts = 5;
    public static int health = 5;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update () {

       

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
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

       

    }
}
