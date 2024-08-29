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


   
    void Update()
    {
        Move();
        BulletSellect();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        
        

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

// bulletType �� Tank�� ������Ʈ Ǯ�� �¸� �ִ� ���� �𸣰ڴ�.
// �Ѿ� ���ñ��� �αװ� �����µ� �� ���� �����°� 1�� �Ѿ˸�?
// Ǯ�� 1,2,3 �� �Ѿ� ��� 5���� ���� �� - �׷� fire���� �������ֳ�?
// �� Tank�� ������Ʈ Ǯ�� �Ѿ˺��� ���� 3�� - ������Ʈ Ǯ�� �߸� ������ �ƴѰ�? - �̰ſ���! 
// �� ��� 1�� ������ƮǮ�� ������ �翬�� 1���Ѿ˸� ������
// ������ capacity�� �����ص� ��ȭ���� 
// ������ ť, ����Ʈ�� �ٲ㵵 ������ ����
// BulletType �迭�� Tank�� ������ �ذ�ƴ� ��?
// 1���Ѿ˸� �߻��ϴ� ���� ����
// �ڷ�ƾ���� 10���� ������� ����
// instance.pool = this; :? 