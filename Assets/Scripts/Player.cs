using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Gateways GatewaysInfoRef;
    public List<AudioClip> Steps;
    private bool isAttacking = false;

    // Start is called before the first frame update
    override public void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    override public void Update()
    {
        offset = Vector3.zero;
        offset.x = Input.GetAxisRaw("Horizontal");
        offset.y = Input.GetAxisRaw("Vertical");

        /*if (Input.GetButtonDown("attack"))
        {
            isAttacking = true;
            StartCoroutine(Attack());
        }
        else*/ 
        if (IsMoving)
        {
            if(!myAudioRef.isPlaying)
            {
                myAudioRef.clip = Steps[GatewaysInfoRef.getCurrentRoom()];
                myAudioRef.Play();
            }
            Move();
        }
        myAnimator.SetBool("moving", IsMoving);
    }


    override public IEnumerator Attack()
    {
        myAnimator.SetBool("attacking", true);
        yield return null; // waits for one frame
        myAnimator.SetBool("attacking", false);
        yield return new WaitForSeconds(0.2f);
        isAttacking = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("enemy") && !isAttacking)
        {
            BeingAttacked(other.transform);
        }
    }
}
