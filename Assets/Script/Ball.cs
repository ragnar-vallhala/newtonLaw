using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float velocity = 0.0f;
    private float height = 0.0f;
    [SerializeField] private float gravity = 9.8f;
    [SerializeField] private float mass = 1.0f;
    float KE = 0;
    float PE = 0;
    private bool dir = false;
    
    void Start()
    {
        height = transform.position.y;
        
    }


    void Update()
    {
        
        
        height = transform.position.y;
        PE = height * mass * gravity;

        height = height - velocity * Time.deltaTime - gravity * Time.deltaTime * Time.deltaTime / 2;
        velocity = velocity + gravity * Time.deltaTime;
        KE = mass * velocity * velocity / 2;
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        float sum = PE + KE;
        Debug.Log("Kinetic energy " + KE + " Potential Energy " + PE + " Sum " + sum);
        
        
    }
}
