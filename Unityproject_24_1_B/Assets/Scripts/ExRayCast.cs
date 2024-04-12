using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                                       //UI�� ����ϱ� ���ؼ�
 using UnityEngine.SceneManagement;                                          //Scene �̵� �ϱ� ���ؼ�

public class ExRayCast : MonoBehaviour
{
    public int Point = 0;                                                       //����Ʈ ��� ����
    public GameObject TargetObject;                                             // Ÿ�� ������
    public float CheckTime = 0;                                                 //Ÿ�� Gen �ð� ����
    public float GameTime = 30.0f;

    public Text pointUI;                                                        //Unity UI ����
    public Text TimeUI;                                                         // Unity UI ����

    // Update is called once per frame
    void Update()
    {
        CheckTime += Time.deltaTime;                                        // �������� �����Ǿ�ð��� ����ϰ� �Ѵ�.
        GameTime -= Time.deltaTime;

        if(GameTime <= 0)
        {
            PlayerPrefs.SetInt("Point", Point);
            SceneManager.LoadScene("MainScene");
        }

        pointUI.text = Point.ToString();                                    //UI ���� ǥ��
        TimeUI.text = "�����ð� : " + GameTime.ToString() + "s";            // UI ���� �ð� ǥ��

        if (CheckTime >= 0.5f)                                               //0.5�� ���� �ൿ�� �Ѵ�.
        {
            int RandomX = Random.Range(0, 12);                                  
            int RandomY = Random.Range(0, 12);
            GameObject temp = Instantiate(TargetObject);                            //Instantiacte �Լ��� ���ؼ� �������� �����Ѵ�.
            temp.transform.position = new Vector3(-6 + RandomX, -6 + RandomY, 0); //������ ���ؼ� -6 ~ 5 ������ ���� �����ϰ� ��ġ
            Destroy(temp, 1.0f);                                                        // 1���� �ı�
            CheckTime = 0;                                                        // �ð� �ʱ�ȭ (0.5�� ���� �ݺ��ϰ� �ϱ� ���ؼ�)

        }
        if (Input.GetMouseButtonDown(0))                                        // ���콺 ������ ��ư�� ������ ���
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);       //ī�޶� ȭ�� �������� ���콺 �����ǿ��� Ray�� ���.

            RaycastHit hit;                                                     //�� Ray��  ����Ȱ��� ������

            if (Physics.Raycast(cast, out hit))                                // Ray�� ����Ȱ��� ������
            {         
                Debug.Log(hit.collider.gameObject.name);                      // ����� ������Ʈ �̸��� ��� ���ش�.
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);      // Ray �������� ǥ�� ���ִ� �Լ�
                
                if(hit.collider.gameObject.tag == "Target")                    // ����� ������Ʈ�� Tag �� Target�� ���
                {
                    Point += 1;
                    Destroy(hit.collider.gameObject);                         // �ش� ���� ������Ʈ�� �ı��Ѵ�
                }
            }   
        }       
    }           
}               
                