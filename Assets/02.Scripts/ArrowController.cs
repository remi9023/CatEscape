using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    
    
    void Start()
    {
        this.player = GameObject.Find("player");// 대문자 GameObject는 객체가 아니다.
    }                                                   // gameObject는 변수이고 GameObject는 타입이다.

   
    void Update()
    {
        transform.Translate(0, -0.05f, 0); // 리지드바디를 쓰지 않고 화살이 자연스럽게 떨어지는 것.
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject); // 소문자 gameObject는 해당 컴포넌트에 할당된  자기자신
        }
        //충돌판정.
        Vector2 p1 = transform.position; // transform.position 는 자기 자신의 좌표를 구하는 메서드.

        Vector2 p2 = this.player.transform.position; // 플레이어의 중심좌표.
        Vector2 dir = p1 - p2; // 방향벡터 구함.
        float d = dir.magnitude;
        float r1 = 0.5f; // 화살의 반경
        float r2 = 1.0f; // 고양이의 반경

        if(d<r1+r2)
        {
            //충돌한 경우 화살을 삭제 메서드 (Destroy)

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().SetHpGauge(); // GameDirector 게임오브젝트 찾아서 스크립트의 SetHPGauge 함수를 실행해주는 코드.
            
            Debug.Log("화살에 맞았다");
            Destroy(gameObject);
            
            
             
        }
         
       
    }
}
