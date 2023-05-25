using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
   
    
    public Text redscoreText; // UI Text 컴포넌트를 가리키는 변수
    public Text yelloscoreText; // UI Text 컴포넌트를 가리키는 변수
    private int redScore = 0; // 빨간색 점수
    private int yellowScore = 0; // 노란색 점수


    private void Start()
    {
        setRedText();
        setYelloText();
    }

    public void GetRedScore(int mount)
    {
        redScore += mount;
        setRedText();
        if(redScore >= 1) 
        {
            EndGame("Red Team");
        }


    }
     public void GetYelloScore(int mount)
    {
        yellowScore += mount;
        setYelloText();
        if(redScore >= 1) 
        {
            EndGame("Blue Team");
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
        // 게임을 종료하는 코드를 여기에 추가하십시오.
        // 예를 들어, 메시지를 표시하거나, 다른 씬을 로드할 수 있습니다.
        Debug.Log(winningTeam + " 게임에 승리했습니다 ! ! !");

        // 1초 후에 Second 씬을 로드합니다.
        Invoke("LoadSecondScene", 1f);
    }

     private void LoadSecondScene()
    {
        SceneManager.LoadScene("second");
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "SelectableObj")
        {
            if (coll.gameObject.tag == "goal")
            {
                GetRedScore(1); // 닿은 공 오브젝트가 goal 태그를 가진 경우 빨간색 점수를 1 증가시킴
            }
            else if (coll.gameObject.tag == "goal2")
            {
                GetYelloScore(1); // 닿은 공 오브젝트가 goal2 태그를 가진 경우 노란색 점수를 1 증가시킴
            }
        }
    }
    

    // private void OnCollisionEnter(Collision coll)
    // {
    //     if (other.CompareTag("SelectableObj"))
    //     {
    //         if (other.CompareTag("goal"))
    //         {
    //             GetRedScore(1); // 닿은 공 오브젝트가 goal 태그를 가진 경우 빨간색 점수를 1 증가시킴
    //         }
    //         else if (other.CompareTag("goal2"))
    //         {
    //             GetYelloScore(1); // 닿은 공 오브젝트가 goal2 태그를 가진 경우 노란색 점수를 1 증가시킴
    //         }
    //     }
    // }

    // private void IncreaseRedScore(int amount)
    // {
    //     redScore += amount; // 빨간색 점수 증가
    //     scoreText.text = "Red: " + redScore.ToString(); // UI Text의 텍스트를 업데이트하여 빨간색 점수를 표시
    // }

    // private void IncreaseYellowScore(int amount)
    // {
    //     yellowScore += amount; // 노란색 점수 증가
    //     scoreText2.text = "Yellow: " + yellowScore.ToString(); // UI Text의 텍스트를 업데이트하여 노란색 점수를 표시
    // }
}
