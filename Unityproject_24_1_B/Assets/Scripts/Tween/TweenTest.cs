using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG. Tweening;         //DoTween�� ����ϱ� ����

public class TweenTest : MonoBehaviour
{
    Tween tween;                    //Ʈ�� ����
    Sequence Sequence;              // ������ ����

 
    void Start()
    {
        /*
        transform.DOMoveX(5, 0.5f);                                         //Tween�� ���ؼ� ������Ʈ�� X������ 2�ʵ��� 5��ŭ �̵�
        transform.DORotate(new Vector3(0, 0, 180), 0.3f);                   //Tween �� ���ؼ� ������Ʈ�� Z������ 0.3�� ���� 180�� ��ŭ ȸ��
        transform.DOScale(new Vector3(2,2,2), 2);                           //Tween�� ���ؼ� ������Ʈ�� 2�ʵ��� 2��� Ŀ����.
       

        Sequence sequence = DOTween.Sequence();                             // �������� �����Ѵ� (�տ� Tween�� ������ ���� Ʈ���� ���۵ȴ�.)
        sequence.Append(transform.DOMoveX(5, 0.5f));
        sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 0.3f));
        sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));
         

        transform.DOMoveX(5, 2f).SetEase(Ease.OutBounce).OnComplete(DeactivateObject);                   // �̵�â�� ȿ���� �߰� ��ų �� �ִ� (Ease.OutBounce)
        transform.DOShakeRotation(2f, new Vector3(0, 0, 5), 10, 90);                                    //�̵��ϴ� ���� ȸ�� ��� ȿ��
        */

        Sequence sequence = DOTween.Sequence();                    // ������ ����
        sequence.Append(transform.DOMoveX(5, 2f));                 // ������ �߰�
        sequence.SetLoops(-1, LoopType.Yoyo);                      //������ ���������� �ɼǵ� ����

    }

    void DeactivateObject() //������ ����� ���Ŀ� �Լ��� ȣ��
    {
        gameObject.SetActive(false);
        Debug.Log("���� ����");
    }

    void Update()
    {
        Sequence.Kill();    //�ش� �������� �����Ѵ�.
        //Tween.kill();     //�ش� Ʈ���� �����Ѵ�.

    }
}
