using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    
    
    void Start()
    {
        this.player = GameObject.Find("player");// �빮�� GameObject�� ��ü�� �ƴϴ�.
    }                                                   // gameObject�� �����̰� GameObject�� Ÿ���̴�.

   
    void Update()
    {
        transform.Translate(0, -0.05f, 0); // ������ٵ� ���� �ʰ� ȭ���� �ڿ������� �������� ��.
        if (transform.position.y < -6.0f)
        {
            Destroy(gameObject); // �ҹ��� gameObject�� �ش� ������Ʈ�� �Ҵ��  �ڱ��ڽ�
        }
        //�浹����.
        Vector2 p1 = transform.position; // transform.position �� �ڱ� �ڽ��� ��ǥ�� ���ϴ� �޼���.

        Vector2 p2 = this.player.transform.position; // �÷��̾��� �߽���ǥ.
        Vector2 dir = p1 - p2; // ���⺤�� ����.
        float d = dir.magnitude;
        float r1 = 0.5f; // ȭ���� �ݰ�
        float r2 = 1.0f; // ������� �ݰ�

        if(d<r1+r2)
        {
            //�浹�� ��� ȭ���� ���� �޼��� (Destroy)

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().SetHpGauge(); // GameDirector ���ӿ�����Ʈ ã�Ƽ� ��ũ��Ʈ�� SetHPGauge �Լ��� �������ִ� �ڵ�.
            
            Debug.Log("ȭ�쿡 �¾Ҵ�");
            Destroy(gameObject);
            
            
             
        }
         
       
    }
}
