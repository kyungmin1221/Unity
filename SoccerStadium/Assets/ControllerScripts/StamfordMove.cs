using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StamfordMove : MonoBehaviour
{
    float moveSpeed = 1500;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Define the speed at which the object moves.

        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        //transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.



        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);  

         if(Input.GetButton("RB")) {
            moveSpeed += 10;
            if(moveSpeed >= 4500)  {
                moveSpeed = 4200;
                Debug.Log(moveSpeed);
         }
        }
        if(Input.GetButtonUp("RB")) {
            moveSpeed = 1500;
            Debug.Log(moveSpeed);
        } 
    }
}
