using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{

    private Animator theanimator;
    void Start()
    {
        theanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            theanimator.SetBool("running", true);
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            theanimator.SetBool("running", false);
        }
    }
}
