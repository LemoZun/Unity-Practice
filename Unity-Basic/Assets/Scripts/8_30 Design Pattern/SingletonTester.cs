using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            // ���� ��𿡼��� ���ӸŴ����� ������ Instance�� Ȱ���� ����� �� �ִ�.
            //�ΰ��� ����
            GameManager.Instance.score++;
            Manager.Game.score++;
        }
    }
}
