using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public ObjectPooling returnPool;
    [SerializeField] float returnTime = 5;
    //[Range(0f,1f)]
    //[SerializeField] float bulletScale;

    private float curTime;


    private void OnEnable()
    {
        curTime = returnTime;
        //transform.localScale = new Vector3(bulletScale, bulletScale, bulletScale);
    }

    private void Update()
    {
        curTime -= Time.deltaTime;
        if(curTime < 0 )
        {
            returnPool.ReturnPool(this);
        }
    }

}
