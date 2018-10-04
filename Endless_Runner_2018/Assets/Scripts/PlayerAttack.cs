using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    bool isAttacking = false;
    public int attackSpeed = 4;
    public GameObject Spinner;

    Vector3 startRotation;



    private void Start()
    {
        startRotation = Spinner.gameObject.transform.eulerAngles;
       
    }

    private void Update()
    {
        if (isAttacking == false)
        {
            if (Input.GetKeyDown("space"))
            {
                isAttacking = true;
            }
        }

        if (isAttacking == true)
        {
            Spinner.gameObject.transform.Rotate(Vector3.up * attackSpeed);

        }

        if (Spinner.gameObject.transform.rotation.eulerAngles.y >= 120)
        {
            isAttacking = false;

            Spinner.gameObject.transform.eulerAngles = startRotation;

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
