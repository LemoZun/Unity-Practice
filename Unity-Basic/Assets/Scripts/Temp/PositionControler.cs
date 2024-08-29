using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PositionControler : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float moveSpeed;
    [SerializeField] int frame;
    [Range(0,1)]
    [SerializeField] float rate;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        //trans.position = new Vector3(1, 0, 2);
        //Application.targetFrameRate = frame;
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        //trans.position += Vector3.forward * moveSpeed * Time.deltaTime; 
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); //이동

        // transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime); // 타겟잡아 이동
        transform.position = Vector3.Lerp(startPosition, target.position, rate*Time.deltaTime); // Lerp는 비율로 움직이면 유연하게 움직이게 할 수 있음

        

    }






}
