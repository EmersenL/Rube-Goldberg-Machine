using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topple : MonoBehaviour
{

    [SerializeField]
    private float torqueStrength = -25.0f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddRelativeTorque(Vector3.down * torqueStrength);
    }
}
