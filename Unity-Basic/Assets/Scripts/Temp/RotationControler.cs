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

    //������ ȸ���ϱ� (������)
    private void RotationRotate()
    {
        angle += rotateSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, angle, 0);
    }

    //������ ȸ���ϱ� (������)
    private void RotateRotate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }

    //�������� �߽����� ����
    private void RotationAround()
    {
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }

    //�������� �ٶ󺸵��� ȸ��
    private void LookAtRotate()
    {
        transform.LookAt(target.position);
    }

}
