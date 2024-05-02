using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenChange : MonoBehaviour
{
    public bool isPunch = false;     //연속적으로 입력이 들어오는것을 막기위한 Flag 값



    void Update()
    {
        if (!isPunch)
        {
            isPunch = true;         //펀치 체크를 True 만들어줘서 계속 입력이 들어지만 로직을 수행 하지 몼하게 막는다.
            transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);        //펀칭 효과를 내고 끝나면 FndPuch 함수호출

        }   
    }
    void EndPunch()
    {
        isPunch = false;
    }
}


