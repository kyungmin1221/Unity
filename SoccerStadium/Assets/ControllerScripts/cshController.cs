using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshController : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip clip;
   
    // Start is called before the first frame update
    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.clip;
        this.audio.loop = false;   
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

       // transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime);
//Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
        float h = Input.GetAxis("XboxH");
        float v = Input.GetAxis("XboxV");
        Vector3 direction = new Vector3(h, v, 0.0f);
        transform.Translate(direction * 10.0f * Time.deltaTime);

        if (Input.GetButton("XboxB"))   // 오른쪽 
        {
            transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
        }
        if (Input.GetButton("XboxX"))     // 왼쪽
        {
            transform.Rotate(Vector3.up * -30.0f * Time.deltaTime);
        }
    
        if (Input.GetButton("XboxA"))    // 아래
        {
            transform.Rotate(Vector3.right * 30.0f * Time.deltaTime);
        }

        if (Input.GetButton("XboxY"))   // 위
        {
            transform.Rotate(Vector3.right * -30.0f * Time.deltaTime);
        }

        
    // Update is called once per frame
      
        if (Input.GetButtonDown("LB"))   
        {
            this.audio.Play();
        }
        if(Input.GetButtonUp("LB")) 
        {
            this.audio.Stop();
        }
       
    
       
        
        
    }
}
