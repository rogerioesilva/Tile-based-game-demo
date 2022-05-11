﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("breakable"))
        {
            other.GetComponent<BreakableItem>().Smash();
        }
        else if (other.CompareTag("enemy"))
        {
            other.gameObject.GetComponent<Enemy>().BeingAttacked(transform);
        }
    }
}
