using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] PooledObject pooledObject;
    [SerializeField] float moveSpeed;
    [SerializeField] float returnTime = 10;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
               
    }
    private void OnEnable()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.forward * moveSpeed * Time.deltaTime;
        currentTime += Time.deltaTime;
        if(currentTime >= returnTime)
        {
            pooledObject.ReturnPool();
        }
    }
}
