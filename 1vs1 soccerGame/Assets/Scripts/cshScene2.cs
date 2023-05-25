using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cshScene2 : MonoBehaviour
{
    
   public void LoadGameScene()
    {
        SceneManager.LoadScene("second"); // 여기서 "GameScene"은 게임 씬의 이름입니다.
    }
}
