using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    // Start is called before the first frame update
    int times = 0;
    void OnCollisionEnter(){
        times++;
        Debug.Log("you collided "+times+" times");
    }
}
