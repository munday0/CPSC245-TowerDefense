using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyBonus : MonoBehaviour
{
    public int totalCurr = 1; //temp val
    public int bonusCurr = 10; //temp val
    public float rotationSpeed = 35;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World); //rotates tower in place
    }

    public void OnTriggerStay(Collider co) //while in the radius of the tower
    {
        if (co.GetComponent<Monster>()) //if there is a monster
        {
            Health health = co.GetComponentInChildren<Health>(); //get the monster's health
            if (!health.isAlive) //aka if the health of the monster reaches 0
            {
                totalCurr += bonusCurr; //add bonus currency to total currency
                Debug.Log("Add bonus currency");
            }
        }
    }
}
