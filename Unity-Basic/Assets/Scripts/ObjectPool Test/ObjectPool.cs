using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] PooledObject prefab;
    [SerializeField] int size;
    [SerializeField] int capacity;
    [SerializeField] bool CreateOnEmpty = true; // �̰� ��� ���°���? �� �ִ°���

    private Stack<PooledObject> pool;
    private void Awake()
    {
        pool = new Stack<PooledObject>(capacity);
        for(int i = 0; i < size; i++)
        {
            PooledObject instance = Instantiate(prefab);
            instance.gameObject.SetActive(false); // ���� �� �ϴ� ��Ȱ��ȭ
            instance.Pool = this; // �̰� ����
            pool.Push(instance);
        }
    }

    public PooledObject GetPool(Vector3 position, Quaternion rotation) // �� �Ű������� ���� ��������? �� �ִ°���?
    {
        Debug.Log("GetPool �޼��� ȣ�� ����");
        if (pool.Count > 0)
        {
            Debug.Log("���� ��");
            PooledObject instance = pool.Pop();
            instance.transform.position = position;
            instance.transform.rotation = rotation;
            instance.gameObject.SetActive(true);
            return instance;
        }
        else
        {
            Debug.Log("5�� ��� ��");
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
