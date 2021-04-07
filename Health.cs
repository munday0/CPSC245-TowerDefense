using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Stephanie Munday
 * ID: 2343625
 * smunday@chapman.edu
 * CPSC 245-01
 * Tower Defense Sprint I
 *
 * Health script - accounts health of castle, monsters
 */

public class Health : MonoBehaviour
{
    public bool IsAlive = true;

    private TextMesh tm;
    // Start is called before the first frame update
    void Start()
    {
        tm = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }

    public int current()
    {
        return tm.text.Length;
    }

    //decreases health and sets status boolean IsAlive which is checked against in other scripts
    public void decrease()
    {
        if (current() > 1)
        {
            tm.text = tm.text.Remove(tm.text.Length - 1);
        }
        else
        {
            IsAlive = false;
            //Debug.Log("Monster destroyed");
            Destroy(transform.parent.gameObject); //destroys monster
        }
    }
}
