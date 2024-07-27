using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Declaring a variable to select the rotation target
    public Transform target;
    public int speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Around the first parameter target position 
        // Rotate Around needs a second parameter about the axis or rotation 
        // Rotate Around needs a third parameter about the speed of rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
