using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UITester : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] Button button;

    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        // 텍스트 설정 바꾸기
        text.color = Color.green;
        text.fontSize = 80;
        text.text = "환영합니다";
    }

    public void Test()
    {
        Debug.Log("클릭");
    }

}
