using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [Range(10, 5000)]
    public float bounceAmount;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * bounceAmount);
    }
}
