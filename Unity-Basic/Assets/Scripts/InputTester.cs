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

        // �� �Է�
        // Horizontal(����) vertical(����)
        float x = Input.GetAxis("Horizontal"); // GetAxis�� �Ƴ��α� ���ĵ� ���� ����

        

    }
}
