using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] List<PooledObject> pool = new List<PooledObject>();
    [SerializeField] PooledObject prefab;
    [SerializeField] int size;

    private void Awake()
    {
       for(int i = 0; i < size; i++)
        {
            PooledObject instance = Instantiate(prefab);
            // instance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            instance.gameObject.SetActive(false); // 오브젝트 비활성화
            instance.transform.parent = transform;
            //instance.transform.parent.position = transform.position;
            //instance.transform.parent.rotation = transform.rotation;
            instance.returnPool = this;

            pool.Add(instance);
        }
    }

    public PooledObject GetPool(Vector3 position, Quaternion rotation)
    {
        if(pool.Count>0)
        {
            PooledObject instance = pool[pool.Count - 1];
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            // instance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            instance.transform.parent = null;
            instance.returnPool = this;
            instance.gameObject.SetActive(true);
            

            pool.RemoveAt(pool.Count - 1);
            return instance;
        }
        else
        {
            PooledObject instance = Instantiate(prefab, position, rotation);
            
            instance.returnPool = this;
            return instance;
        }
      
    }

    public void ReturnPool(PooledObject instance)
    {
        instance.gameObject.SetActive(false);
        // instance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        instance.transform.parent = transform;
        //instance.transform.parent.position = transform.position;
        //instance.transform.parent.rotation = transform.rotation;
        pool.Add(instance);
    }
}
