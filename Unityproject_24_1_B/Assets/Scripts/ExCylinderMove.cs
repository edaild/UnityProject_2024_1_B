using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ExCylinderMove : MonoBehaviour
{
    public float MoveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 헤당 스크립트가 붙어있는 오브젝트는 X축 마이너스 방향으로 이동 한다.
        // += 는 x += 7 < - X = X + 1 축약 해주는 표시
        // Vector3는 x,y,z 축을 나타내는 변수
        
        gameObject.transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * Time.deltaTime * MoveSpeed;

        if(gameObject.transform.position.x <-12) //x 축 좌표가 -12 미만으로 내려갈때
        {
            gameObject.transform.position += new Vector3(24.0f, 0.0f, 0.0f); // 오른쪽으로 x축 24만큼 이동
        }
    }
}
