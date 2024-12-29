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
            delta = 0f; // 델타 시간 초기화

            //오브젝트를 생성해줌
            GameObject arrow = Instantiate(arrowPrefab);
            arrow.transform.position = new Vector3(Random.Range(-9.8f,9.8f), 6f,0f) ;
        }
    }
}
