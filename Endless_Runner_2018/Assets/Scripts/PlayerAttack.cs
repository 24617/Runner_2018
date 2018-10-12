using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    private Animation animator;
    bool isAttacking = false;
    private int attackSpeed = 4;
    bool AttackRefresher = false;
    float AttackRefreshTimer = 0;
    float RefreshTime = 1.5f;
    public GameObject Spinner;
    public GameObject Character;
    public AudioSource AttackSound;

    Vector3 startRotation;

    private void Start()
    {
        startRotation = Spinner.gameObject.transform.eulerAngles;
       
    }

    private void Update()
    {
        if (AttackRefresher == false)
        {
            if (isAttacking == false)
            {
                if (Input.GetKeyDown("space"))
                {
                    isAttacking = true;
                    Character.GetComponent<Animator>().SetTrigger("PlayerAttack");
                    AttackSound.Play();
                }
            }
        }

        if (isAttacking == true)
        {
            
            Spinner.gameObject.transform.Rotate(Vector3.up * attackSpeed);
            AttackRefreshTimer += Time.deltaTime;
            
        }
        

        if (Spinner.gameObject.transform.rotation.eulerAngles.y >= 120)
        {
            isAttacking = false;
            AttackRefresher = true;
            Spinner.gameObject.transform.eulerAngles = startRotation;

        }

        if (AttackRefresher == true)
        {
            AttackRefreshTimer += Time.deltaTime;
            if (AttackRefreshTimer >= RefreshTime)
            {
                AttackRefreshTimer = 0;
                AttackRefresher = false;
            }
        }

    }

    private void OnTriggerEnter(Collider col)
    {
        if (isAttacking == true)
        {
            if (col.tag == "Enemy")
            {
                Destroy(col.gameObject);

            }
        }
    }





}
