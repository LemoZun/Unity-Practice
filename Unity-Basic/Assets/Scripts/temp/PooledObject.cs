using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public ObjectPool returnPool;
    [SerializeField] float returnTime = 5;

    private float curTime;


    private void OnEnable()
    {
        curTime = returnTime;
        transform.localScale = new Vector3(0.5f,0.5f,0.5f);
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
