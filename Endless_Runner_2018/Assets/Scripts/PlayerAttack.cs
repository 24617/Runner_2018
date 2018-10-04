using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    bool isAttacking = false;
    public int attackSpeed = 4;

    Vector3 startRotation;



    private void Start()
    {
        startRotation = this.gameObject.transform.eulerAngles;
        Debug.Log(startRotation + "hello");
    }

    private void Update()
    {


        if (Input.GetKey("space"))

        {

            Attack();


        }
        else
        {
            this.gameObject.transform.eulerAngles = startRotation;
        }

        Debug.Log(this.gameObject.transform.rotation.eulerAngles.y);
    }


    public void Attack()
    {
        this.gameObject.transform.Rotate(Vector3.back * attackSpeed);

        Debug.Log(this.gameObject.transform.rotation.eulerAngles.y + "    CHECKING!!!");


        if (this.gameObject.transform.rotation.eulerAngles.y < -90)
        {
            this.gameObject.transform.eulerAngles = startRotation;
            Debug.Log("reset");
        }
    }


}
