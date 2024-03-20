using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI�� ����ϱ����ؼ� �߰�

public class ExMouseButton : MonoBehaviour
{
    public int Hp = 100;
    public Text testUI;  //UI �۾� ���ڿ� �߰�

    void Update()
    {
        testUI.text = "ü�� : " + Hp.ToString(); // UI�� ü�� ǥ��

        if (Input.GetMouseButtonDown(0))    // ���콺 �Է��� ������ ��
        {
            Hp -= 10;
            Debug.Log("ü�� : " + Hp); //ü��Ȯ���� ���� Debug.Log �Լ�
            if(Hp <= 0)
            {
                testUI.text = "ü�� : " + Hp.ToString();
                Destroy(gameObject); // �� ������Ʈ�� �ı��Ѵٴ� �Լ�
            }    
        }  
    }
}

