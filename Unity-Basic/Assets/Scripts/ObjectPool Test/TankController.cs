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

// bulletType 에 Tank의 오브젝트 풀을 셋만 넣는 이유 모르겠다.
// 총알 선택까진 로그가 나오는데 왜 정작 나가는건 1번 총알만?
// 풀에 1,2,3 번 총알 모두 5개씩 들어가긴 함 - 그럼 fire에서 문제가있나?
// ㄴ Tank의 오브젝트 풀은 총알별로 각각 3개 - 오브젝트 풀을 잘못 넣은거 아닌가? - 이거였다! 
// ㄴ 모두 1번 오브젝트풀을 넣으니 당연히 1번총알만 나간것
// 스택의 capacity를 조정해도 변화없음 
// 스택을 큐, 리스트로 바꿔도 동작은 같음
// BulletType 배열에 Tank를 넣으니 해결됐다 왜?
// 1번총알만 발사하는 문제 있음
// 코루틴으로 10초후 사라지게 만듬
// instance.pool = this; :? 