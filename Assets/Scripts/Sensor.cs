using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    protected GameObject myAgent;

    // Start is called before the first frame update
    public virtual void Start()
    {
        myAgent = transform.parent.gameObject;
    }
}
