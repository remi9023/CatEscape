using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ArrowGenerator : MonoBehaviour
{
   public GameObject arrowPrefab;
    public float spawn;
    float delta = 0f;
  

   
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > spawn)
        {
            delta = 0f; // ��Ÿ �ð� �ʱ�ȭ

            //������Ʈ�� ��������
            GameObject arrow = Instantiate(arrowPrefab);
            arrow.transform.position = new Vector3(Random.Range(-9.8f,9.8f), 6f,0f) ;
        }
    }
}
