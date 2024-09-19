using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Walk : MonoBehaviour
{

    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            mAnimator.SetTrigger("walk");
        }
        
        if(Input.GetKeyUp(KeyCode.S))
        {
            mAnimator.SetTrigger("Slow run");
        }
    }
}
    