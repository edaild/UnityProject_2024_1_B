using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{

    public Rigidbody m_Rigidbody;             //리지드 바디를 소스를 사용하게 받아 온다.
    public int Force = 100;     
    public int point = 0;       // 점수 사용할 변추 추가
    public float checkTime = 0; // 시간 측정을 위한 변수
    public Text m_Text;
    // int 정수로 힘을 100을 설정 한다.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0)) // 마우스 입력이 들어왔을 때
        if(Input.GetKeyDown(KeyCode.Space)) // 스페이스 입력이 들어왔을 때
        {
            m_Rigidbody.AddForce(transform.up * Force);
        }

        checkTime += Time.deltaTime;            //프레임 시작을 더해서 시간을 측정
        if (checkTime >= 1.0f)                   // 만약 1초가 지날경우
        {
            point += 1;
            checkTime = 0.0f;               // 1초가 지날 경우 초기화    
        }
        m_Text.text = point.ToString();     //UI 표시
    }
    
    private void OnCollisionEnter(Collision collision)       //충돌이 시작되었을 때
    {
        if(collision != null)                            //충돌 물체가 존재할 경우
        {
            point = 0;
            gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
            Debug.Log(collision.gameObject.name); //해당 오브젝트의 이름을 출력한다.  
        }
    }
}
