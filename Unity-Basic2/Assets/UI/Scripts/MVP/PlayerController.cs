using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // 1.UI(View) / Data(Model) �и� - UI�� �����͸� �����ϸ� �ȵ�
    // 2. Model ���濡 ���� �̺�Ʈ ����
    // 3. View���� Model ���濡 ���� �̺�Ʈ�� ����� UI ������ �۾�
    // (��õ : OnEnable ���, OnDisable ���� / Start���� �ʱ� ����)
    // �� �ں��� controller�� model�� �����͸� �����ϸ� => �ڵ����� UI�� �����

    [Header("UI")]
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] Slider hpSlider;
    [SerializeField] TextMeshProUGUI mpText;
    [SerializeField] Slider mpSlider;

    [Header("Model")]
    [SerializeField] PlayerModel model;

    [Header("Property")]
    [SerializeField] float jumpPower;
    private void OnEnable()
    {
        model.OnHPChanged += UpdateHP;
        model.OnMPChanged += UpdateMP;
    }

    private void OnDisable()
    {
        model.OnHPChanged -= UpdateHP;
        model.OnMPChanged -= UpdateMP;

    }
    private void Start()
    {
        UpdateHP(model.HP);
        UpdateMP(model.MP);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            model.HP += 10;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            model.MP += 10;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            model.MP -= 10;
        }

    }

    private void UpdateHP(int hp)
    {
        hpText.text = $"{hp}";
        hpSlider.value = hp;
    }

    private void UpdateMP(int mp)
    {
        hpText.text = $"{mp}";
        mpSlider.value = mp;
    }

    //private void Jump()
    //{
    //    rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    //    score++;
    //    scoreText.text = $"���� ���� : {score}";
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    score++;
    //}

}
