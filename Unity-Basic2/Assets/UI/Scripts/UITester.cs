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
        // �ؽ�Ʈ ���� �ٲٱ�
        text.color = Color.green;
        text.fontSize = 80;
        text.text = "ȯ���մϴ�";
    }

    public void Test()
    {
        Debug.Log("Ŭ��");
    }

}
