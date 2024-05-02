using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TweenColor : MonoBehaviour
{
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();    //GetComponent �� �ڽ� ������Ʈ���� ������Ʈ(Renderer)�� �˻��Ͽ� �����´�.
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color color = new Color(Random.value , Random.value, Random.value); // ���� �÷� ����

            renderer.material.DOColor(color, 1f)                            //���� ������ �÷η� Ʈ����
               .SetEase(Ease.InOutQuad)                                     //�ɼ� �� ����
                .SetAutoKill(false)
                .Pause()
                .OnComplete(() => Debug.Log("�÷� ��ȯ �Ϸ�"));               //�͸��Լ����� �α� Ȱ��ȭ [() =>]

            renderer.material.DOPlay();                                       //������ Ʈ���� ����


        }
    }
}