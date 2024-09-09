using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTester : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;


    [System.Flags] // 열거형 복수 체크 가능
    enum MonsterType
    {
        Fire = 1 << 0,
        Water =1 << 1,
        Grass = 1 << 2,
        Electric = 1 << 3
    }

    [SerializeField] MonsterType monsterType;

    private void Start()
    {
        // 1. 특정 레이어 체크
        // layerMask : 0000 1110
        // 체크레이어 : 0100 0000
        // | (or) 연산 --------------
        // 결과      : 0100 1110 

        layerMask = layerMask | (1 << 6);
        //복합 연산자 사용시
        layerMask |= (1 << 6);

        // 2. 특정 레이어 해제
        // layerMask : 0110 1100
        // 체크레이어 : 1011 1111
        // & (and)연산 ------------
        // 결과      : 0010 1100

        layerMask = layerMask & ~(1 << 6);
        //복합 연산자 사용시
        layerMask &= ~(1 << 6);

        // 3. 특정 레이어 확인
        // layerMask : 0110 1100
        // 체크레이어 : 0100 0000
        // &    -------------------
        // 결과      : 0100 0000

        bool isChecked = (layerMask & (1 << 6)) != 0;
        Debug.Log(isChecked);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(layerMask.Contain(collision.gameObject.layer))
        {
            //충돌한 오브젝트가 지정한 레이어마스크에 포함되어있을 경우 처리
        }
    }


}
