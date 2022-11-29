using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [Range(10, 5000)]
    public float bounceAmount;

    public Vector3 a;
    public Vector3 b;
    public Vector3 c;

    private Vector3 normal;

    private void Start()
    {
        GameObject par = this.gameObject.transform.parent.gameObject;
        Transform pointA = par.transform.GetChild(1);
        //print("what child is this?" + pointA.name);
        Transform pointB = par.transform.GetChild(2);
        //print("what child is this?" + pointB.name);
        Transform pointC = par.transform.GetChild(3);
        //print("what child is this?" + pointC.name);
        a = pointA.position;
        b = pointB.position;
        c = pointC.position;
        Vector3 side1 = b - a;
        Vector3 side2 = c - a;
        normal = Vector3.Cross(side1, side2);
        normal.x = normal.x * -1;
        normal.y = normal.y * -1;
        normal.z = normal.z * -1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject bouncer = collision.gameObject;
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();
        rb.AddForce(normal * bounceAmount);
    }
}
