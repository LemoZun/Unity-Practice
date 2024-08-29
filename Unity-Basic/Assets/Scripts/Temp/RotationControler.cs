using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationControler : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] float angle;
    [SerializeField] Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(target.position);
        

    }

    //축으로 회전하기 (값으로)
    private void RotationRotate()
    {
        angle += rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }

    //축으로 회전하기 (각도로)
    private void RotateRotate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    //기준점을 중심으로 돌기
    private void RotationAround()
    {
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }

    //기준점을 바라보도록 회전
    private void LookAtRotate()
    {
        transform.LookAt(target.position);
    }

}
