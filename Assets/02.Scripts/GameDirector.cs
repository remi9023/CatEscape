using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge; // HP 바
    public GameObject GameOver_Panel; // 게임 오버 패널
    public Text Playtime_Text; // 플레이 타임 텍스트
    private float delta = 0f; // 플레이 시간 기록
    public static bool isGameOver = false; // 게임 오버 상태
    public GameObject arrowGenerator;
    public PlayerController player;  

       void Update()
    {
        // 게임이 진행 중일 때만 플레이 타임 증가
        if (!isGameOver)
        {
            delta += Time.deltaTime;
            Playtime_Text.text = delta.ToString("F2") + "s";
        }
    }
    private void Awake()
    {
        Time.timeScale = 1f;// 재시작 했을 때 다시 타이머가 작동하게
        arrowGenerator.SetActive(true); // 화살도 다시 만들어지게
    }


    public void SetHpGauge()
    {
        
                // HP 감소
        hpGauge.fillAmount -= 0.1f;

        // 게임 오버 조건 확인
        if (hpGauge.fillAmount <= 0)
        {
           
            player.moveSpeed = 0f;
            arrowGenerator?.SetActive(false);
            isGameOver = true; // 게임 오버 상태로 변경
            GameOver_Panel.SetActive(true); // 게임 오버 패널 활성화
        }
    }

    public void RestartGame()
    {
        // 게임 재시작
        isGameOver = false; // 게임 오버 상태 초기화
        SceneManager.LoadScene("SampleScene"); // 현재 씬 다시 로드
    }
}