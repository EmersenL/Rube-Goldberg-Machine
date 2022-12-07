using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnSparks : MonoBehaviour
{
    public GameObject sparks;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ring")
        {
            // print("working");
            sparks.SetActive(true);
        }
    }
}
