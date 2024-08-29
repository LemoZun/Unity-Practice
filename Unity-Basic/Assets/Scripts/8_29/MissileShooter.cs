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

        //if (Input.GetKey(KeyCode.Space)) // ������ �ִ��� // �ֱ⸦ �����ϱ� �ָ��ؼ� �ʹ� ���� ����
        //{ //�̷��� �ڷ�ƾ ���� ����
        //    Instantiate(missilePrefab, transform.position, transform.rotation);
        //}

        // repeatTime ���� ����
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
            WaitForSeconds delay = new WaitForSeconds(repeatTime); // ĳ��
            Instantiate(missilePrefab, transform.position, transform.rotation);
            yield return delay;
        }
    }

    // �ڷ�ƾ ����
    // �ڷ�ƾ�� �ݺ��۾� �� ����ó���� ������ �۾��� ���� Ÿ�̹� ���� ����
    IEnumerator CoroutineWait()
    {
        WaitForSeconds delay = new WaitForSeconds(repeatTime);

        yield return null; // �� ������ ���� = Update�� ����
        yield return new WaitForSeconds(1f); // n�ʰ� �ð� ����
        yield return new WaitForSecondsRealtime(1f); // ���� n�ʰ� �ð� ����
        yield return new WaitForFixedUpdate(); // FixedUpdate ���� ����
        yield return new WaitForEndOfFrame(); // �������� ������ ����
        yield return new WaitUntil(() => true); // ������ �����Ҷ����� ����

    }


}

