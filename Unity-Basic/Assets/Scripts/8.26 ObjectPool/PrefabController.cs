using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabController : MonoBehaviour
{
    [SerializeField] GameObject tankPrefab;
    [SerializeField] Rigidbody rigidPrefab;
    
    [SerializeField] GameObject instance;
    [SerializeField] Rigidbody rigidInstance;

    [SerializeField] GameObject destroyTarget;
    [SerializeField] GameObject destroyInstance;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //instance = Instantiate(tankPrefab, transform.position, transform.rotation); // �������� �ʿ����
            //instance.name = ($"�ν��Ͻ� ��ũ - {count}");
            //count++;

            //�����ڸ��� ���� �ִ¹�, ������Ʈ�� ������ �ν��Ͻ��� ���� ���� �ִ�.
            rigidInstance =  Instantiate(rigidPrefab,transform.position,transform.rotation);
            rigidInstance.AddForce(Vector3.up * 10, ForceMode.Impulse);
            rigidInstance.name = ($"�ν��Ͻ� ��ũ - {count}");
            count++;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Destroy(destroyTarget);
            Destroy(destroyTarget); // 1�� �� �����
        }

    }
}
