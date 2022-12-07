using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator balloonAnim;
    public GameObject cherry;

    private void OnCollisionEnter(Collision collision)
    {
        balloonAnim.SetBool("Trigger", true);
        StartCoroutine(WaitForCherry());
    }

    IEnumerator WaitForCherry()
    {
        yield return new WaitForSeconds(10);
        cherry.SetActive(true);
    }
}
