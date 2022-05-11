using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSensor : Sensor
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            myAgent.GetComponent<Loggy>().PlayerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAgent.GetComponent<Loggy>().PlayerInRange = false;
        }
    }
}
