using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    [SerializeField] PlayerMover player;
    [SerializeField] float rotateSpeed;
    [SerializeField] Vector3 offset;
    private Transform playerTransform;
    Coroutine rayCoroutine;
    private void Start()
    {
        playerTransform = player.transform;
        if (rayCoroutine == null)
            rayCoroutine = StartCoroutine(RayRoutine());
    }

    private void LateUpdate()
    {
        CheckObstacle();
        FollowPlayer();
        RotateCamera();
    }

    private void OnDestroy()
    {
        if(rayCoroutine != null)
            StopCoroutine(rayCoroutine);
    }

    private void FollowPlayer()
    {
        transform.position = playerTransform.position + offset;
    }

    private void RotateCamera()
    {
        if (Input.GetMouseButton(1))
        {
            float x = Input.GetAxis("Mouse X");
            float y = Input.GetAxis("Mouse Y");

            
            transform.RotateAround(playerTransform.position, Vector3.up, x* rotateSpeed);
            transform.RotateAround(playerTransform.position, transform.right, -y * rotateSpeed);

            offset = transform.position - playerTransform.position;
        }
    }

    IEnumerator RayRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(0.1f);
        while (true)
        {
            CheckObstacle();
            yield return delay;

        }

    }

    private void CheckObstacle()
    {
        
        Vector3 rayDistance = (playerTransform.position - transform.position);
        Vector3 rayDirection = rayDistance.normalized;
        Debug.DrawRay(transform.position, rayDistance, Color.red);
        if(Physics.Raycast(transform.position, rayDistance, out RaycastHit hit))
        {
            
            if(hit.collider.CompareTag("Obstacle"))
            {
                Debug.Log("장애물에 막힘!");
                //transform.position = playerTransform.position - rayDirection * hit.distance;
                // 계산이 잘못됨
                Debug.Log("땡기라고");
                transform.position = transform.position + rayDirection * ( hit.distance - 100f);
                
                //transform.position =  (playerTransform.position - transform.position) -(rayDirection*hit.distance);
                transform.LookAt(playerTransform.position);
            }
        }

    }
}
//transform.LookAt(playerTransform.position);
//transform.rotation = Quaternion.Euler(player.X,0,player.Z);
//transform.Rotate(Vector3.up, player.RotateSpeed)
//transform.position = playerTransform.position + playerTransform.TransformDirection(offset);
//transform.rotation = playerTransform.rotation;
//transform.LookAt(playerTransform.position);
//transform.rotation = Quaternion.Euler(player.X,0,player.Z);
//transform.Rotate(Vector3.up, player.RotateSpeed)
//transform.position = playerTransform.position + playerTransform.TransformDirection(offset);
//transform.rotation = playerTransform.rotation;
