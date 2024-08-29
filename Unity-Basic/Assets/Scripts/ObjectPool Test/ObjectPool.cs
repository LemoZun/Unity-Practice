using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] PooledObject prefab;
    [SerializeField] int size;
    [SerializeField] int capacity;
    [SerializeField] bool CreateOnEmpty = true; // 이건 어디에 쓰는거지? 왜 있는거지

    private Stack<PooledObject> pool;
    private void Awake()
    {
        pool = new Stack<PooledObject>(capacity);
        for(int i = 0; i < size; i++)
        {
            PooledObject instance = Instantiate(prefab);
            instance.gameObject.SetActive(false); // 생성 후 일단 비활성화
            instance.Pool = this; // 이게 뭘까
            pool.Push(instance);
        }
    }

    public PooledObject GetPool(Vector3 position, Quaternion rotation) // 이 매개변수는 무슨 역할이지? 왜 주는거지?
    {
        Debug.Log("GetPool 메서드 호출 시작");
        if (pool.Count > 0)
        {
            Debug.Log("스택 팝");
            PooledObject instance = pool.Pop();
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.gameObject.SetActive(true);
            return instance;
        }
        else
        {
            Debug.Log("5발 모두 쏨");
            return null;
        }
        
    }
     public void ReturnPool(PooledObject _instance)
    {
        if(pool.Count < capacity)
        {
            _instance.gameObject.SetActive(false);
            pool.Push(_instance);
        }
        else
        {
            Destroy(_instance.gameObject);
        }
    }
}
