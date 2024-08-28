using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsControler : MonoBehaviour
{
    [SerializeField] Transform camTransform;
    [SerializeField] float rotateSpeed;
    [SerializeField] float moveSpeed;
    [SerializeField] Transform muzzlePoint;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Move();
        Look();
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }

    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * z * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right*x*moveSpeed * Time.deltaTime);
    }

    private void Look()
    {
        float x = Input.GetAxis("Mouse X"); // 마우스 좌우 움직임 량
        float y = Input.GetAxis("Mouse Y"); // 마우스 상하 움직임 량

        transform.Rotate(Vector3.up, rotateSpeed * x * Time.deltaTime);
        camTransform.Rotate(Vector3.right,rotateSpeed * -y * Time.deltaTime);
    }

    private void Fire()
    {
        //Debug.DrawRay(camTransform.position, camTransform.forward, Color.red);

        if(Physics.Raycast(camTransform.position,camTransform.forward, out RaycastHit hit))
        {
            Debug.DrawRay(camTransform.position, camTransform.forward * hit.distance, Color.red);
            GameObject instance = hit.collider.gameObject;
            Target target = instance.GetComponent<Target>();

            if (target != null)
            {
                target.TakeHit();
            }

            
        }
    }
}
