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
            //instance = Instantiate(tankPrefab, transform.position, transform.rotation); // 프리팹을 필요로함
            //instance.name = ($"인스턴스 탱크 - {count}");
            //count++;

            //만들자마자 힘을 주는법, 컴포넌트를 참조해 인스턴스를 만들 수도 있다.
            rigidInstance =  Instantiate(rigidPrefab,transform.position,transform.rotation);
            rigidInstance.AddForce(Vector3.up * 10, ForceMode.Impulse);
            rigidInstance.name = ($"인스턴스 탱크 - {count}");
            count++;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Destroy(destroyTarget);
            Destroy(destroyTarget); // 1초 뒤 지우기
        }

    }
}
