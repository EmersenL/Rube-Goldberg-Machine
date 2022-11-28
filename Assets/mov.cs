using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float x = 0.0001f;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);
        rb.velocity = Vector3.zero;
        rb.isKinematic = true;
     
    }
}
