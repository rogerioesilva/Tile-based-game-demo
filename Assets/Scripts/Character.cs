using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MobileItem
{
    public float knockingTime = 0.4f;
    public float Thrust = 5f;
    public int health = 5;
    protected bool isKnockingBack = false;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    override public void Update()
    {
        base.Update();
    }

    protected void Move()
    {
        myRigidbody.MovePosition(transform.position + offset.normalized * speed * Time.deltaTime);
        myAnimator.SetFloat("moveX", offset.x);
        myAnimator.SetFloat("moveY", offset.y);
    }

    virtual public IEnumerator Attack()
    {
        yield return null;
    }

    public void BeingAttacked(Transform origin)
    {
        if (isKnockingBack)
            return;

        Vector2 difference = transform.position - origin.position;
        difference = difference.normalized * Thrust;
        myRigidbody.AddForce(difference, ForceMode2D.Impulse);
        isKnockingBack = true;
        StartCoroutine(Knocked());
        health--;
        if (health == 0)
            Destroy(gameObject);
    }

    protected IEnumerator Knocked()
    {
        yield return new WaitForSeconds(knockingTime);
        myRigidbody.velocity = Vector2.zero;
        isKnockingBack = false;
    }
}
