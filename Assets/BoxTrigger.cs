using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public GameObject SpinPoint; //wrecking ball object
    public GameObject default1;
    

    void OnTriggerStay (Collider other){
        default1.GetComponent<SwingBall>().Activate = true;    
    }
}
