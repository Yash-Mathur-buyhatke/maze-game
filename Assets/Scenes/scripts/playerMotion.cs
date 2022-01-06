using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMotion : MonoBehaviour
{
    float moveSpeed = 10f;
    [SerializeField] float xValue = -172.5f;
    [SerializeField] float zValue = 86.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move front
        if(Input.GetKey(KeyCode.UpArrow)){
            xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(xValue,0f,-zValue);
        
        }
        // Move down
        if(Input.GetKey(KeyCode.DownArrow)){
            xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(-xValue,0f,-zValue);
        
        }
        // Move right
        if(Input.GetKey(KeyCode.RightArrow)){
            xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(-xValue,0f,-zValue);
        
        }
        // Move left
        if(Input.GetKey(KeyCode.LeftArrow)){
            xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            transform.Translate(-xValue,0f,zValue);
        
        }
        
    
    }
}
