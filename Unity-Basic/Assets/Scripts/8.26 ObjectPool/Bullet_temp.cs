using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed;

    
    void Start()
    {
        //삭제할때
        //Destroy(gameObject,5);
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime,Space.Self);
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }
   
}
