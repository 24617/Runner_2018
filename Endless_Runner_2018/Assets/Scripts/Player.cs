using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public List<float> Lanes = new List<float>();

    private int Lane = 0;
    bool StartGame = false;
    private bool invincible = false;

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

            }
        }
    }

    private IEnumerator GotHit()
    {
            for (int i = 0; i < 3; i++)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                yield return new WaitForSeconds(0.2f);
                gameObject.GetComponent<Renderer>().enabled = true;
                yield return new WaitForSeconds(0.2f);
            }
        invincible = false;
    }
}
