using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator balloonAnim;

    private void OnCollisionEnter(Collision collision)
    {
        balloonAnim.SetBool("Trigger", true);
    }
}
