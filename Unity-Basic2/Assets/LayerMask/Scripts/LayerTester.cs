using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerTester : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;


    [System.Flags] // ������ ���� üũ ����
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
        // 1. Ư�� ���̾� üũ
        // layerMask : 0000 1110
        // üũ���̾� : 0100 0000
        // | (or) ���� --------------
        // ���      : 0100 1110 

        layerMask = layerMask | (1 << 6);
        //���� ������ ����
        layerMask |= (1 << 6);

        // 2. Ư�� ���̾� ����
        // layerMask : 0110 1100
        // üũ���̾� : 1011 1111
        // & (and)���� ------------
        // ���      : 0010 1100

        layerMask = layerMask & ~(1 << 6);
        //���� ������ ����
        layerMask &= ~(1 << 6);

        // 3. Ư�� ���̾� Ȯ��
        // layerMask : 0110 1100
        // üũ���̾� : 0100 0000
        // &    -------------------
        // ���      : 0100 0000

        bool isChecked = (layerMask & (1 << 6)) != 0;
        Debug.Log(isChecked);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(layerMask.Contain(collision.gameObject.layer))
        {
            //�浹�� ������Ʈ�� ������ ���̾��ũ�� ���ԵǾ����� ��� ó��
        }
    }


}
