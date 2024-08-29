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
        Debug.Log("Fire 메서드 호출 시작"); // 호출 확인

        PooledObject bulletCheck =  sellectedBullet.GetPool(muzzlePoint.position,muzzlePoint.rotation);

        if(bulletCheck != null)
        {
            Debug.Log("총알이 생성됨");
        }
        else
        {
            Debug.Log("총알이 생성되지 않음");
        }
    }

    private void BulletSellect()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            sellectedBullet = bulletType[0];
            Debug.Log("1번 총알 선택");
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            sellectedBullet = bulletType[1];
            Debug.Log("2번 총알 선택");
        }
        else if( Input.GetKeyDown(KeyCode.Alpha3))
        {
            sellectedBullet = bulletType[2];
            Debug.Log("3번 총알 선택");
        }
    }
}
