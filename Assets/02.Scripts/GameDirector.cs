using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // 재시작 원할 때
using UnityEngine.UI;// UI를 사용할 때 꼭 추가해주기! *중요


public class GameDirector : MonoBehaviour
{
   public Image hpGauge;
   public GameObject gameOver_panel;
   bool isGameStart = false; 
   bool isGameOver = false; // 초기 게임 오버 상태는 거짓상태로 시작
    public Text Playtime_Text;
    float delta = 0f;
    
    void Update()
         
    {
     this.delta += Time.deltaTime;   
        Playtime_Text.text=delta.ToString("F2")+"s";
    }

    public void SetHpGauge()
    {
        hpGauge.fillAmount -= 0.1f;
               
        //게임 오버가 되었다고 알려주면 될 것 같다.
        if (hpGauge.fillAmount <= 0)
        {
            //게임 오버 텍스트 출력
            isGameOver = true;
            //재시작 버튼 출력
           
           // 게임오버 패널 켜주면 그 안에 게임오버에 관한 것들이 다 들어있다.
           gameOver_panel.SetActive(true);
               
        }
    
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Gamescene"); // 현재 씬 재시작
    }

}
