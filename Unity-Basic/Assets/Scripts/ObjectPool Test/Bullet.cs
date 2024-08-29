using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] PooledObject pooledObject;
    
    [SerializeField] float moveSpeed;
    [SerializeField] float returnTime = 10f;
 
    private Coroutine bulletLife;
    
    private void OnEnable()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletLife == null)
        {
            bulletLife = StartCoroutine(BulletDestroyRoutine());
        }
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //currentTime += Time.deltaTime;
        //if(currentTime >= returnTime)
        //{
        //    pooledObject.ReturnPool();
        //}
    }

    IEnumerator BulletDestroyRoutine()
    {
        yield return new WaitForSeconds(returnTime);
        Debug.Log("10초 지남");
        pooledObject.ReturnPool();
        Debug.Log("리턴풀");
        StopCoroutine(bulletLife);
        bulletLife = null;
        
        
    }
}
