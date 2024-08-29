using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceControler : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); // 기본적으로 Space.Self 를 씀 (자기 자신을 기준)
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime,Space.World); // (세상을 기준)
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);
    }
}
