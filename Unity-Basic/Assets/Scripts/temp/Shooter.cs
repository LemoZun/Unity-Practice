using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] ObjectPool bulletPool;    
    [SerializeField] Transform muzzlePoint;
    [Range(1,10)]
    [SerializeField] float bulletSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        //MuzzlePoint .transform = 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    public void Fire()
    {
        //GameObject instance = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //Bullet bullet = instance.GetComponent<Bullet>();.
        // //생성해서 사용
        //Bullet bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //bullet.SetSpeed(bulletSpeed);

        //대여해서 사용
        PooledObject instance = bulletPool.GetPool(muzzlePoint.position, muzzlePoint.rotation);
        Bullet bullet = instance.GetComponent<Bullet>();
        bullet.SetSpeed(bulletSpeed);
    }
}
