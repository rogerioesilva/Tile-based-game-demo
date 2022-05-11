using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected Animator myAnimator;
    protected AudioSource myAudioRef;

    // Start is called before the first frame update
    virtual public void Start()
    {
        myAnimator = GetComponent<Animator>();
        myAudioRef = GetComponent<AudioSource>();
    }

    virtual public void Update() { }
}
