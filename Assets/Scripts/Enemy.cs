using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    public string enemyName;
    protected Transform refPlayer;

    // Start is called before the first frame update
    override public void Start()
    {
        refPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        base.Start();
    }

    // Update is called once per frame
    override public void Update()
    {
        base.Update();
    }
}
