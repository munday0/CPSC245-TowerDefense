using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Stephanie Munday
 * ID: 2343625
 * smunday@chapman.edu
 * CPSC 245-01
 * Tower Defense Sprint I
 *
 * Buildplace script - allows for different towers to be placed on buildplaces
 */

public class Buildplace : MonoBehaviour
{
    public GameObject TowerPrefab;
    public GameObject CurrTowerPrefab;
    private int towerType;

    private void Update()
    {
        //check if key input is 1 or 2, assigns tower type
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            towerType = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            towerType = 2;
        }
    }

    //instantiates tower prefab based on set tower type
    private void OnMouseUpAsButton()
    {
        if (towerType == 1)
        {
            GameObject g = (GameObject)Instantiate(TowerPrefab);
            g.transform.position = transform.position + Vector3.up;
        }
        else if (towerType == 2)
        {
            GameObject c = (GameObject)Instantiate(CurrTowerPrefab);
            c.transform.position = transform.position + Vector3.up;
        }
        else
        {
            Debug.Log("Do not place");

        }
    }
}
