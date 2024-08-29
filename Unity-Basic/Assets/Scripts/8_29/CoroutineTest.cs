using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    private Coroutine delayJumpCoroutine;
    

    void Update()
    {
        Debug.Log("Update");

        if(Input.GetKeyDown(KeyCode.Space) )
        {
            if(delayJumpCoroutine == null )
            {
                delayJumpCoroutine = StartCoroutine(DelayJump());
            }
            
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            if ((delayJumpCoroutine != null))
            {
                StopCoroutine(delayJumpCoroutine); // ƒ⁄∑Á∆æ ∞¥√º∏¶ ∏ÿ√Á¡‡æﬂ«‘ , ∏ﬁº≠µÂ∞° æ∆¥‘
                delayJumpCoroutine = null;
            }
            
        }

    }
    IEnumerator DelayJump()
    {
        Debug.Log("3");
        yield return new WaitForSeconds(1f);
        Debug.Log("2");
        yield return new WaitForSeconds(1f);
        Debug.Log("1");
        yield return new WaitForSeconds(1f);

        rigid.AddForce(Vector3.up* 10f, ForceMode.Impulse);

        delayJumpCoroutine = null;
    }


    IEnumerator Routine()
    {
        Debug.Log("Coroutine 0");
        yield return new WaitForSeconds(1f);        
        Debug.Log("Coroutine 1");
        yield return new WaitForSeconds(1f);
        Debug.Log("Coroutine 2");
        yield return new WaitForSeconds(1f);
        Debug.Log("Coroutine 3");
        yield return new WaitForSeconds(1f);
        Debug.Log("Coroutine 4");

    }
}
