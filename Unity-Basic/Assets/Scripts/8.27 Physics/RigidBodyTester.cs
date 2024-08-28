using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyTester : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float power;
    
    void Start()
    {
        //rigid.AddForce(Vector3.up*)
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * power, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            rigid.AddTorque(Vector3.up*power,ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rigid.velocity = new Vector3(1, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigid.angularVelocity = new Vector3(1, 0, 1);
        }


    }

}
