using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshController : MonoBehaviour
{
    public float m_moveSpeed = 2.0f;
    public GameObject ball;
    public float shootingPower = 0.5f; // And this
    public float shootingDistance = 2f; // 슈팅 가능 거리


    void Update()
    {
        PlayerMove();

        // Add this block
        if(Input.GetKeyDown(KeyCode.Space) && IsBallInRange())
        {
            ShootBall();
        }
    }

    void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveHorizontal = Vector3.right * h;
        Vector3 moveVertical = Vector3.forward * v;
        Vector3 velocity = (moveHorizontal + moveVertical).normalized;

        transform.LookAt(transform.position + velocity);

        transform.Translate(velocity * m_moveSpeed * Time.deltaTime, Space.World);
 	
    }
   void ShootBall()
    {
        Rigidbody ballRb = ball.GetComponent<Rigidbody>();
        if(ballRb != null)
        {
            Vector3 shootingDirection = transform.forward;
            ballRb.AddForce(shootingDirection * shootingPower, ForceMode.Impulse);
        }
    }

    bool IsBallInRange()
    {
        float distance = Vector3.Distance(transform.position, ball.transform.position);
        return distance <= shootingDistance;
    }

}
