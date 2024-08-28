using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint;
    [Range(0f, 100f)]
    [SerializeField] float maxDistance;
    [SerializeField] LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
        // Physics.Raycast(��� ��ġ, ��� ����,RaycastHit(�ε��� ����), �ִ�Ÿ�, ���̾��ũ(�浹�� Ȯ���� Ÿ�� �׷�));
        
        if(Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance, layerMask))  //��ȯ�� bool, (��� ��ġ
        {
            // �������� �ε����� ���� ��
            Debug.Log($"{hit.collider.gameObject.name}�̶� �ε���, �Ÿ��� {hit.distance}m ������ �ִ�.");
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward*hit.distance, Color.red);
        }
        else
        {
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward*maxDistance, Color.green);
            // �������� �ε����� ���� �� 
        }
    }

    private void OnDrawGizmos()
    {
        //Gizmos.color = Color.blue;
        //Gizmos.DrawWireSphere(transform.position, 3f);
    }
    private void OnDrawGizmosSelected()
    {
        //Gizmos.color = Color.blue;
        //Gizmos.DrawWireSphere(transform.position, 3f);
    }

}

