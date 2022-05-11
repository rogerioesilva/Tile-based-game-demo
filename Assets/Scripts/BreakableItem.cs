using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BreakableItem : Item
{
    public override void Start()
    {
        base.Start();
    }
    public void Smash()
    {
        myAnimator.SetBool("Smashed", true);
        StartCoroutine(OnSmash());
    }
    IEnumerator OnSmash()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
    }
}

