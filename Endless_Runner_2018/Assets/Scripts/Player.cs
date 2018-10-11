using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

 
    public List<float> Lanes = new List<float>();
    public bool die = false;
    private int Lane = 0;
    bool StartGame = false;
    private bool invincible = false;
    public GameObject Character;

    int getHealth = HearthCounter.health;
    private IEnumerator coroutine;
   

    void Start () {
        Lanes.Add(-3.5f);
        Lanes.Add(-2f);
        Lanes.Add(-0.5f);
        Lanes.Add(1f);
    }


    void Update() {

        transform.position += Vector3.right * Time.deltaTime * 5;
        transform.position = new Vector3(transform.position.x, transform.position.y, Lanes[Lane]);
        

        if (Input.GetKeyDown("up"))
        {
            if (Lane == 2 || Lane == 1 || Lane == 0)
            {
                Lane += 1;
               
            }
                
        }

        if (Input.GetKeyDown("down"))
        {
            if (Lane == 1 || Lane == 2 || Lane == 3)
            {
                Lane -= 1;
            }

        }

    }

    public void Die()
    {
        SceneManager.LoadScene("deathScreen");
        Debug.Log(die);
    
        
    }

    private void OnTriggerEnter(Collider col)
    {

        if (invincible == false)
        {
            if (col.tag == "Enemy")
            {
                HearthCounter.health -= 1;
                invincible = true;
                coroutine = GotHit();
                StartCoroutine(coroutine);
                if (HearthCounter.health == 0)
                {
                    Debug.Log("U DIED");
                    die = true;
                    Die();
                }

            }
        }
    }

    private IEnumerator GotHit()
    {
            for (int i = 0; i < 3; i++)
            {
                Character.gameObject.GetComponent<Renderer>().enabled = false;
                yield return new WaitForSeconds(0.2f);
                Character.gameObject.GetComponent<Renderer>().enabled = true;
                yield return new WaitForSeconds(0.2f);
            }
        invincible = false;
    }
}
