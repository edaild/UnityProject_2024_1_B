using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI를 사용하기위해서 추가

public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text testUI;  //UI 글씨 문자열 추가

    void Update()
    {
        testUI.text = "체력 : " + Hp.ToString(); // UI에 체력 표시

        if (Input.GetMouseButtonDown(0))    // 마우스 입력이 들어왔을 때
        {
            Hp -= 10;
            Debug.Log("체력 : " + Hp); //체력확인을 위한 Debug.Log 함수
            if(Hp <= 0)
            {
                testUI.text = "체력 : " + Hp.ToString();
                Destroy(gameObject); // 이 오브젝트를 파괴한다는 함수
            }    
        }  
    }
}

