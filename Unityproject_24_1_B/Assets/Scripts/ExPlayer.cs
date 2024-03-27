using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExPlayer : MonoBehaviour
{

    public Rigidbody m_Rigidbody;             //������ �ٵ� �ҽ��� ����ϰ� �޾� �´�.
    public int Force = 100;     
    public int point = 0;       // ���� ����� ���� �߰�
    public float checkTime = 0; // �ð� ������ ���� ����
    public Text m_Text;
    // int ������ ���� 100�� ���� �Ѵ�.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0)) // ���콺 �Է��� ������ ��
        if(Input.GetKeyDown(KeyCode.Space)) // �����̽� �Է��� ������ ��
        {
            m_Rigidbody.AddForce(transform.up * Force);
        }

        checkTime += Time.deltaTime;            //������ ������ ���ؼ� �ð��� ����
        if (checkTime >= 1.0f)                   // ���� 1�ʰ� �������
        {
            point += 1;
            checkTime = 0.0f;               // 1�ʰ� ���� ��� �ʱ�ȭ    
        }
        m_Text.text = point.ToString();     //UI ǥ��
    }
    
    private void OnCollisionEnter(Collision collision)       //�浹�� ���۵Ǿ��� ��
    {
        if(collision != null)                            //�浹 ��ü�� ������ ���
        {
            point = 0;
            gameObject.transform.position = new Vector3(0.0f, 3.0f, 0.0f);
            Debug.Log(collision.gameObject.name); //�ش� ������Ʈ�� �̸��� ����Ѵ�.  
        }
    }
}
