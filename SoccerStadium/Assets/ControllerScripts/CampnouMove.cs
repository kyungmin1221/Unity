using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampnouMove : MonoBehaviour
{
     float moveSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float moveSpeed = 100;
        //Define the speed at which the object moves.

        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        //transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.



        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);   

        if(Input.GetButton("RB")) {
            moveSpeed += 20;
            if(moveSpeed >= 1000)  {
                moveSpeed = 500;
                Debug.Log(moveSpeed);
         }
        }
        if(Input.GetButtonUp("RB")) {
            moveSpeed = 100;
            Debug.Log(moveSpeed);
        }
       
        
    }
}
