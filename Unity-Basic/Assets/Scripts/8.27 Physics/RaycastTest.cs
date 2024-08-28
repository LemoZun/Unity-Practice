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
        
       
        // Physics.Raycast(쏘는 위치, 쏘는 방향,RaycastHit(부딪힌 정보), 최대거리, 레이어마스크(충돌을 확인할 타겟 그룹));
        
        if(Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, maxDistance, layerMask))  //반환형 bool, (쏘는 위치
        {
            // 레이저에 부딪힌게 있을 때
            Debug.Log($"{hit.collider.gameObject.name}이랑 부딪힘, 거리는 {hit.distance}m 떨어져 있다.");
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward*hit.distance, Color.red);
        }
        else
        {
            Debug.DrawRay(muzzlePoint.position, muzzlePoint.forward*maxDistance, Color.green);
            // 레이저에 부딪힌게 없을 때 
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

