using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventReceiver : MonoBehaviour
{
    [SerializeField] EventTester tester;
    [SerializeField] Rigidbody rigid;

    private void OnEnable()
    {
        tester.OnScream += Jump;
    }

    private void OnDisable()
    {
        tester.OnScream -= Jump;       
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up *8f, ForceMode.Impulse);
    }

}
