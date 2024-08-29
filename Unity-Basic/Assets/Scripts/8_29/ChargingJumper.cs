using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargingJumper : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float chargingTime;

    Coroutine chargerCoroutine;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            chargerCoroutine = StartCoroutine(ChargerRoutine());
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(chargerCoroutine);
            rigid.AddForce(Vector3.up * chargingTime ,ForceMode.Impulse);
        }

        IEnumerator ChargerRoutine()
        {
            chargingTime =0;
            WaitForSeconds delay = new WaitForSeconds(0.1f);
            while(true)
            {
                yield return delay;
                chargingTime += 0.1f;
            }
        }
            
    }
}
