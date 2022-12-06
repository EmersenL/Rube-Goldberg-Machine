using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBall : MonoBehaviour
{
    public bool Activate = false;
    float speed = 30.0f;
    
    // Update is called once per frame
    void Update()
    {        
            if (Activate){
                transform.Rotate(Vector3.right * speed * Time.deltaTime);
            }
    }
}
