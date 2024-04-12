using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExMainScene : MonoBehaviour
{
    public Text pointUI;
    void Start()
    {
        pointUI.text = PlayerPrefs.GetInt("Point").ToString();      // ����� ����Ʈ ������ UI ǥ��
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("GameScene_Shoot");          // ���� ������ ����.
    }

}
