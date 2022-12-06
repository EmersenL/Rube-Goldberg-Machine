using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBall : MonoBehaviour
{
    public bool Activate = false;
    private bool done = true;
    //float speed = 30.0f;
    public Rigidbody rb;

    private void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {        
            if (Activate && done){
                print("activated");
                rb.useGravity = true;
                done = false;
                // transform.Rotate(Vector3.right * speed * Time.deltaTime);
            }
    }
}
