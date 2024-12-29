using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // ����� ���� ��
using UnityEngine.UI;// UI�� ����� �� �� �߰����ֱ�! *�߿�


public class GameDirector : MonoBehaviour
{
   public Image hpGauge;
   public GameObject gameOver_panel;
   bool isGameStart = false; 
   bool isGameOver = false; // �ʱ� ���� ���� ���´� �������·� ����
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
               
        //���� ������ �Ǿ��ٰ� �˷��ָ� �� �� ����.
        if (hpGauge.fillAmount <= 0)
        {
            //���� ���� �ؽ�Ʈ ���
            isGameOver = true;
            //����� ��ư ���
           
           // ���ӿ��� �г� ���ָ� �� �ȿ� ���ӿ����� ���� �͵��� �� ����ִ�.
           gameOver_panel.SetActive(true);
               
        }
    
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Gamescene"); // ���� �� �����
    }

}
