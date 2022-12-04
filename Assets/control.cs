using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{

    public Transform Sparks;

    // Start is called before the first frame update
    void Start()
    {
        Sparks.GetComponent<ParticleSystem> ().enableEmission = true;
    }

    // Trigger on collision
    void OnCollisionEnter(Collision collision)
    {
        Sparks.GetComponent<ParticleSystem> ().enableEmission = true;
        StartCoroutine (StopSparks ());
    }

    IEnumerator StopSparks()
    {
        yield return new WaitForSeconds(.9f);

        Sparks.GetComponent<ParticleSystem> ().enableEmission = false;
    }
}
