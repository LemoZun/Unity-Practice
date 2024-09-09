using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Transform cameraTransform;
    private Vector3 direction;



    private void Update()
    {
        Move();
        Look();
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal"); // -1 , 0, 1
        float z = Input.GetAxisRaw("Vertical");

        direction = new Vector3(x, 0, z).normalized;

        if (direction.magnitude >= 0) // 0도 포함 안하면 에러가 뜸
        {
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.Self);
        }
    }

    private void Look()
    {
        Vector3 cameraView = cameraTransform.forward;
        cameraView.y = 0;
        cameraView.Normalize();
        transform.forward = cameraView;
    }

    //private void Look()
    //{
    //    float x = Input.GetAxis("Mouse X");
    //    float y = Input.GetAxis("Mouse Y");

    //    if (Input.GetMouseButton(1)) //홀드상태로 유지
    //    {
    //        transform.Rotate(Vector3.up, rotateSpeed * x * Time.deltaTime,Space.Self);
    //        //transform.Rotate(Vector3.left, rotateSpeed * y * Time.deltaTime);
    //        //cameraTransform.Rotate(Vector3.up, rotateSpeed * x * Time.deltaTime);
    //        //cameraTransform.Rotate(Vector3.left, rotateSpeed* y * Time.deltaTime);
    //    }
    //}


}
