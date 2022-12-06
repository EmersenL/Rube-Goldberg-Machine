using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour
{
    public GameObject SpinPoint; //wrecking ball object
    

    void OnTriggerStay (Collider other){
        SpinPoint.GetComponent<SwingBall>().Activate = true;    
    }
}
