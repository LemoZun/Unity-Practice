using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Enter : {other.gameObject.name}"); // 충돌된 오브젝트의 이름을 출력

    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log($"Stay : {other.gameObject.name}");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log($"Exit : {other.gameObject.name}");
    }
}
