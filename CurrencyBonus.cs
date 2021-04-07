using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Stephanie Munday
 * ID: 2343625
 * smunday@chapman.edu
 * CPSC 245-01
 * Tower Defense Sprint I
 *
 * Currency bonus tower script - monsters killed within radius will give extra energy
 */

public class CurrencyBonus : MonoBehaviour
{
    public int TotalCurr = 1; //temp val
    public int BonusCurr = 10; //temp val
    private float rotationSpeed = 35;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World); //rotates tower in place
    }

    //checks to see if monster is killed within tower radius, adds extra energy if so
    public void OnTriggerStay(Collider co) //while in the radius of the tower
    {
        if (co.GetComponent<Monster>()) //if there is a monster
        {
            Health health = co.GetComponentInChildren<Health>(); //get the monster's health
            if (!health.IsAlive) //aka if the health of the monster reaches 0
            {
                TotalCurr += BonusCurr; //add bonus currency to total currency
                Debug.Log("Add bonus currency");
            }
        }
    }
}
