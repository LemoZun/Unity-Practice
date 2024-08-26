using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rate;
    [SerializeField] float rotateSpeed;
    [SerializeField] bool zMove;
    [SerializeField] bool xMove;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //if(xMove == false)
        //    x = 0;
        //if(zMove == false)
        //    z = 0;


        Vector3 moveDir = new Vector3 (x, 0, z);

        if (moveDir == Vector3.zero)
            return; //�ƹ��͵� �ȴ�������

        //�Ϲ�ȭ
        moveDir.Normalize();

        // �̵� 
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);

        //ȸ�� 
         Quaternion lookRotation = Quaternion.LookRotation(moveDir); // �ٶ󺸴� �������� ȸ��

        // ȸ������ �����ؼ� �ε巴�� ȸ���ϴ� ���
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, rate * Time.deltaTime);

        // transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, rotateSpeed);

    }

    private void Move()
    {

    }

    

}
