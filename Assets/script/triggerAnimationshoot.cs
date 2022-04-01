using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimationshoot : MonoBehaviour
{
    private Animator shootAnimation;

    public void shootAni()
    {
        shootAnimation = GetComponent<Animator>();
        shootAnimation.SetBool("isShooting", true);
    }
    public void idelAni()
    {
        shootAnimation = GetComponent<Animator>();
        shootAnimation.SetBool("isShooting", false);
    }
}
