using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventTester : MonoBehaviour
{
    public event Action OnScream;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scream();
        }
            
    }

    private void Scream()
    {
        Debug.Log("�÷��̾ �Ҹ��� ���� ");
        OnScream?.Invoke(); // �̺�Ʈ �߻���Ű��  
    }
}
