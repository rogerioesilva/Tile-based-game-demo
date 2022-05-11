using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loggy : Enemy
{
    public bool PlayerInRange;

    // Start is called before the first frame update
    override public void Start()
    {
        enemyName = "Loggy";
        PlayerInRange = false;
        base.Start();
    }

    // Update is called once per frame
    override public void Update()
    {
        if(PlayerInRange && !isKnockingBack)
        {
            Vector3 direction = Vector3.MoveTowards(transform.position, refPlayer.position, speed * Time.deltaTime);
            myRigidbody.MovePosition(direction);
            myAnimator.SetBool("wakeUp", true);
            myAnimator.SetFloat("moveX", (direction - transform.position).normalized.x);
            myAnimator.SetFloat("moveY", (direction - transform.position).normalized.y);
        }
        else
        {
            myAnimator.SetBool("wakeUp", false);
        }
        base.Update();
    }
}
