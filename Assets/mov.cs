using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    [SerializeField]
    private float x = 0.00001f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);
     
    }
}
