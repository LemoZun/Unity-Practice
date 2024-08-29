using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"Update : {Time.deltaTime}");
    }
    private void FixedUpdate()
    {
        Debug.Log($" FixedUpdate : {Time.fixedDeltaTime} , {Time.deltaTime}");
    }
}
