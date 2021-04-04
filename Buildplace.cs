using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildplace : MonoBehaviour
{
    public GameObject towerPrefab;
    public GameObject currTowerPrefab;
    private int towerType;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            towerType = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            towerType = 2;
        }
    }

    private void OnMouseUpAsButton()
    {
        if (towerType == 1)
        {
            GameObject g = (GameObject)Instantiate(towerPrefab);
            g.transform.position = transform.position + Vector3.up;
        }
        else if (towerType == 2)
        {
            GameObject c = (GameObject)Instantiate(currTowerPrefab);
            c.transform.position = transform.position + Vector3.up;
        }
        else
        {
            Debug.Log("Do not place");

        }
    }
}
