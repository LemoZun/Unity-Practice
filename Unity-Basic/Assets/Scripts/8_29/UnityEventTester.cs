using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventTester : MonoBehaviour
{
    //public UnityEvent Onscream;
    public UnityEvent<float> Onscream;
    [SerializeField] float ScreamVolume;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Scream();
        }

    }

    private void Scream()
    {
        Debug.Log("플레이어가 소리를 지름 ");
        Onscream?.Invoke(ScreamVolume);
         
    }
}
