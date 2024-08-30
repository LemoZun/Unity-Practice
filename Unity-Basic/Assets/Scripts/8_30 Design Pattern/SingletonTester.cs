using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTester : MonoBehaviour
{
    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            // 게임 어디에서나 게임매니저를 쓰려면 Instance를 활용해 사용할 수 있다.
            //두개가 같음
            GameManager.Instance.score++;
            Manager.Game.score++;
        }
    }
}
