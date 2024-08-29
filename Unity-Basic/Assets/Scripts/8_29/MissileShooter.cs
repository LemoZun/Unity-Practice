using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileShooter : MonoBehaviour
{
    [SerializeField] GameObject missilePrefab;
    [SerializeField] Coroutine missileSpawnRoutine;
    [SerializeField] float repeatTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyUp(KeyCode.Space))
        //{
        //    Instantiate(missilePrefab,transform.position, transform.rotation);
        //}

        //if (Input.GetKey(KeyCode.Space)) // 누르고 있는중 // 주기를 지정하기 애매해서 너무 많이 나감
        //{ //이럴떄 코루틴 쓰기 좋음
        //    Instantiate(missilePrefab, transform.position, transform.rotation);
        //}

        // repeatTime 마다 연사
        if(Input.GetKeyDown(KeyCode.Space))
        {
            missileSpawnRoutine = StartCoroutine(MissileSpawnRoutine());
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(missileSpawnRoutine);
        }

    }

    IEnumerator MissileSpawnRoutine()
    {
        while(true)
        {
            WaitForSeconds delay = new WaitForSeconds(repeatTime); // 캐싱
            Instantiate(missilePrefab, transform.position, transform.rotation);
            yield return delay;
        }
    }

    // 코루틴 지연
    // 코루틴은 반복작업 중 지연처리를 정의해 작업의 진행 타이밍 지정 가능
    IEnumerator CoroutineWait()
    {
        WaitForSeconds delay = new WaitForSeconds(repeatTime);

        yield return null; // 한 프레임 지연 = Update와 동일
        yield return new WaitForSeconds(1f); // n초간 시간 지연
        yield return new WaitForSecondsRealtime(1f); // 현실 n초간 시간 지연
        yield return new WaitForFixedUpdate(); // FixedUpdate 까지 지연
        yield return new WaitForEndOfFrame(); // 프레임의 끝까지 지연
        yield return new WaitUntil(() => true); // 조건이 충족할때까지 지연

    }


}

