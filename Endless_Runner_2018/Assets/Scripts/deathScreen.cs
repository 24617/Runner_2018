using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreen : MonoBehaviour {


	public void Home() {
        SceneManager.LoadScene("MainMenu");
    }
	
    public void Retry () {
        SceneManager.LoadScene("Game");

    }
}
