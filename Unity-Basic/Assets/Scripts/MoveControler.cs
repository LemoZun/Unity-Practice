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
            return; //아무것도 안눌렀을때

        //일반화
        moveDir.Normalize();

        // 이동 
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);

        //회전 
         Quaternion lookRotation = Quaternion.LookRotation(moveDir); // 바라보는 방향으로 회전

        // 회전률을 적용해서 부드럽게 회전하는 방법
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, rate * Time.deltaTime);

        // transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, rotateSpeed);

    }

    private void Move()
    {

    }

    

}
