using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshShoot : MonoBehaviour
{
   public float speed = 10f;
    public float power = 10f;
    public string playerID = "1"; 

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal" + playerID);
        float moveVertical = Input.GetAxis("Vertical" + playerID);

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

        if (Input.GetButtonDown("Fire" + playerID))
        {
            rb.AddForce(transform.up * power, ForceMode.Impulse);
        }
    }
}
