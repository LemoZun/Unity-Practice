using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("TitleScene");
        }
        if(Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("MainGameScene");
        }
    }
}
