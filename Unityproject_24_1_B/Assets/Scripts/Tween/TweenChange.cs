using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenChange : MonoBehaviour
{
    public bool isPunch = false;     //���������� �Է��� �����°��� �������� Flag ��



    void Update()
    {
        if (!isPunch)
        {
            isPunch = true;         //��ġ üũ�� True ������༭ ��� �Է��� ������� ������ ���� ���� ���ϰ� ���´�.
            transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);        //��Ī ȿ���� ���� ������ FndPuch �Լ�ȣ��

        }   
    }
    void EndPunch()
    {
        isPunch = false;
    }
}


