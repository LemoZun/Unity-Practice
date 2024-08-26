using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTester : MonoBehaviour
{
   

  
    void Update()
    {
        if (Input.GetButton("Attack"))
        {
            Debug.Log("Attack is pressing");
        }
        if (Input.GetButtonUp("Attack"))
        {

        }
        if(Input.GetButtonDown("Attack"))
        {

        }

        // 축 입력
        // Horizontal(수평) vertical(수직)
        float x = Input.GetAxis("Horizontal"); // GetAxis는 아날로그 형식도 지원 가능

        

    }
}
