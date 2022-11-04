using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//  지정한 컴포넌트를 필수로 가져야 한다는것을 의미
// 만약 내가 원하는 속성을 가지고 있지 않았을 때 자동 추가됌 
[RequireComponent(typeof(Rigidbody))]
public class PlayerBehavior : MonoBehaviour
{
    private Rigidbody rb;
    //[Tolltip("공이 왼쪽오른쪽으로 얼나 빠게 움ㅣ이는지")]
    [Tooltip("how fast the ball moves left/rigt")]
    public float ballSpeed = 5;
    [Range(0,10)]
    public float rollSpeed = 5;
    // Start is called before the first frame update
    private void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        var horizontalSpeed = Input.GetAxis("Horizontal") * ballSpeed;
        rb.AddForce(horizontalSpeed,0,rollSpeed);
    }
}
