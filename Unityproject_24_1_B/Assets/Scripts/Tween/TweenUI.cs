using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;


public class TweenUI : MonoBehaviour
{

    public float duration = 1f;
    public Image image;
 
    void Start()
    {
        image = GetComponent<Image>();          //�̹��� ������Ʈ�� �����´�.

        image.DOFade(0f, duration)              //UI Fade �� �Ѵ�. 0 : ����ó��
            .SetEase(Ease.InOutQuad)            //�ɼ� �� ����
            .SetAutoKill(false)
            .Pause()
            .OnComplete(() => Debug.Log("UI �Ϸ�"));  // �͸��Լ����� �α� Ȱ��ȭ [() =>

        image.DOPlay();
    }
}
