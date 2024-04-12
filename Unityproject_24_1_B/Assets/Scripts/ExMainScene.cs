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
        pointUI.text = PlayerPrefs.GetInt("Point").ToString();      // 저장된 포인트 점수를 UI 표시
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("GameScene_Shoot");          // 게임 씬으로 들어간다.
    }

}
