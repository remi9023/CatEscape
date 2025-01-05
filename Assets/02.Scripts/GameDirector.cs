using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge; // HP ��
    public GameObject GameOver_Panel; // ���� ���� �г�
    public Text Playtime_Text; // �÷��� Ÿ�� �ؽ�Ʈ
    private float delta = 0f; // �÷��� �ð� ���
    public static bool isGameOver = false; // ���� ���� ����
    public GameObject arrowGenerator;
    public PlayerController player;  

       void Update()
    {
        // ������ ���� ���� ���� �÷��� Ÿ�� ����
        if (!isGameOver)
        {
            delta += Time.deltaTime;
            Playtime_Text.text = delta.ToString("F2") + "s";
        }
    }
    private void Awake()
    {
        Time.timeScale = 1f;// ����� ���� �� �ٽ� Ÿ�̸Ӱ� �۵��ϰ�
        arrowGenerator.SetActive(true); // ȭ�쵵 �ٽ� ���������
    }


    public void SetHpGauge()
    {
        
                // HP ����
        hpGauge.fillAmount -= 0.1f;

        // ���� ���� ���� Ȯ��
        if (hpGauge.fillAmount <= 0)
        {
           
            player.moveSpeed = 0f;
            arrowGenerator?.SetActive(false);
            isGameOver = true; // ���� ���� ���·� ����
            GameOver_Panel.SetActive(true); // ���� ���� �г� Ȱ��ȭ
        }
    }

    public void RestartGame()
    {
        // ���� �����
        isGameOver = false; // ���� ���� ���� �ʱ�ȭ
        SceneManager.LoadScene("SampleScene"); // ���� �� �ٽ� �ε�
    }
}