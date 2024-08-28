using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField] ObjectPool[] bulletType;
    [SerializeField] private ObjectPool sellectedBullet;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] Transform muzzlePoint;
    

    private void Awake()
    {
        sellectedBullet = bulletType[0];
    }


    // Update is called once per frame
    void Update()
    {
        Move();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        BulletSellect();
        

    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.forward*z*moveSpeed*Time.deltaTime);
        transform.Rotate(Vector3.up*x*rotateSpeed*Time.deltaTime);
    }

    private void Fire()
    {
        Debug.Log("Fire �޼��� ȣ�� ����"); // ȣ�� Ȯ��

        PooledObject bulletCheck =  sellectedBullet.GetPool(muzzlePoint.position,muzzlePoint.rotation);

        if(bulletCheck != null)
        {
            Debug.Log("�Ѿ��� ������");
        }
        else
        {
            Debug.Log("�Ѿ��� �������� ����");
        }
    }

    private void BulletSellect()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            sellectedBullet = bulletType[0];
            Debug.Log("1�� �Ѿ� ����");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            sellectedBullet = bulletType[1];
            Debug.Log("2�� �Ѿ� ����");
        }
        else if( Input.GetKeyDown(KeyCode.Alpha3))
        {
            sellectedBullet = bulletType[2];
            Debug.Log("3�� �Ѿ� ����");
        }
    }
}
