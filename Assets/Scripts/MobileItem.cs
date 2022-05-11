using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MobileItem : Item
{
    public float speed;
    protected Vector3 offset;
    protected Rigidbody2D myRigidbody;
    protected bool IsMoving
    {
        get
        {
            return offset != Vector3.zero;
        }
    }

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    override public void Update()
    {
        base.Update();
    }
}
