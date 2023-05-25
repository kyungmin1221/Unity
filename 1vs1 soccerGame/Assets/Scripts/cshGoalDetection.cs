using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 


public class cshGoalDetection : MonoBehaviour
{
    private Vector3 initialPosition;
    private Rigidbody ballRb;   // add
    public GameObject ball;
    public Text redscoreText; // UI Text 컴포넌트를 가리키는 변수
    public Text yelloscoreText; // UI Text 컴포넌트를 가리키는 변수
    private int redScore = 0; // 빨간색 점수
    private int yellowScore = 0; // 노란색 점수
   

    private void Start()
    {
        initialPosition = ball.transform.position;
        ballRb = ball.GetComponent<Rigidbody>();   // add
        setRedText();
        setYelloText();
    }

    public void GetRedScore(int mount)
    {
        redScore += mount;
        setRedText();
        if (redScore >= 5)
        {
            EndGame("Red Team");
        }

    }

    public void GetYelloScore(int mount)
    {
        yellowScore += mount;
        setYelloText();
        if (yellowScore >= 5)
        {
            EndGame("BLUE Team");
        }

    }

    public void setRedText() 
    { 
        redscoreText.text = "Score : " + redScore.ToString();
    }
    
     public void setYelloText() 
    {    
        yelloscoreText.text = "Score : " + yellowScore.ToString();
    }

    private void EndGame(string winningTeam) 
    {    
        Debug.Log(winningTeam + " 이 게임에 승리 하였습니다 ! ! !");

        // 1초 후에 Second 씬을 로드합니다.
        Invoke("LoadSecondScene", 1f);
    }

    private void LoadSecondScene()
    {
        SceneManager.LoadScene("second");
    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "goal")
        {
            Debug.Log("!! Red Team Goal !! !");
           // transform.position = initialPosition; // 위치 초기화
            ResetBall();
            GetRedScore(1);
            //transform.position = initialPosition; // 위치 초기화

            // Instantiate(particlePrefab, transform.position, Quaternion.identity);
            // Instantiate(particlePrefab2, transform.position, Quaternion.identity);
        }
        if (collision.gameObject.tag == "goal2")
        {
            Debug.Log("!! Yello Team Goal !! !");
           // transform.position = initialPosition; // 위치 초기화
            ResetBall();
            GetYelloScore(1);
            //transform.position = initialPosition; // 위치 초기화

            // Instantiate(particlePrefab, transform.position, Quaternion.identity);
            // Instantiate(particlePrefab2, transform.position, Quaternion.identity);
        }
    }
    // add
    private void ResetBall()
    {
        ball.transform.position = initialPosition; // 위치 초기화
        ballRb.velocity = Vector3.zero; // 선형 속도 초기화
        ballRb.angularVelocity = Vector3.zero; // 각 속도 초기화
    }
    
}
//  public Text redscoreText; // UI Text 컴포넌트를 가리키는 변수
//     public Text yelloscoreText; // UI Text 컴포넌트를 가리키는 변수
//     private int redScore = 0; // 빨간색 점수
//     private int yellowScore = 0; // 노란색 점수


//     private void Start()
//     {
//         setRedText();
//         setYelloText();
//     }

//     public void GetRedScore(int mount)
//     {
//         redScore += mount;
//         setRedText();

//     }
//      public void GetYelloScore(int mount)
//     {
//         yellowScore += mount;
//         setYelloText();

//     }

//     public void setRedText() 
//     { 
//         redscoreText.text = "Score : " + redScore.ToString();
//     }
//      public void setYelloText() 
//     {    
//         yelloscoreText.text = "Score : " + yellowScore.ToString();
//     }

//     private void OnCollisionEnter(Collision coll)
//     {
//         if (coll.gameObject.tag == "SelectableObj")
//         {
//             if (coll.gameObject.tag == "goal")
//             {
//                 GetRedScore(1); // 닿은 공 오브젝트가 goal 태그를 가진 경우 빨간색 점수를 1 증가시킴
//             }
//             else if (coll.gameObject.tag == "goal2")
//             {
//                 GetYelloScore(1); // 닿은 공 오브젝트가 goal2 태그를 가진 경우 노란색 점수를 1 증가시킴
//             }
//         }
//     }
