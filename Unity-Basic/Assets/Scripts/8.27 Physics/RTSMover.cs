using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSMover : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] GameObject playerObject;
    [SerializeField] PlayerMover playerMover;
    [SerializeField] LayerMask groundMask;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerMover = playerObject.GetComponent<PlayerMover>();
        //layerMask = 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)) //마우스 우클릭
        {
            MovePlayer();
        }    
        
    }

    private void MovePlayer()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit,100f,groundMask))
        {
            Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red, 0.2f);            
            playerMover.Move(hit.point);
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.yellow, 0.2f);
        }
        
    }
}
