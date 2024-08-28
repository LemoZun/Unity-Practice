using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    //[SerializeField] Vector3 speed;
    [Range(0f, 1f)]
    [SerializeField] float bulletScale;


    void Start()
    {
        //삭제할때
        //Destroy(gameObject,5);
    }
    private void OnEnable()
    {
        
        transform.localScale = new Vector3(bulletScale, bulletScale, bulletScale);
    }

    void Update()
    {

        //transform.Translate(Vector3.forward * speed * Time.deltaTime,Space.Self);
    }

    public void SetSpeed(Vector3 speed)
    {
        rigid.velocity = speed;
        //this.speed = speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("플레이어 공격");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("다른 물체와 충돌");
            //Destroy(gameObject);
        }
    }

}
