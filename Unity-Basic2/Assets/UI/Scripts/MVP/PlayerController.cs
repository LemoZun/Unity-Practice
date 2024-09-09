using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // 1.UI(View) / Data(Model) 분리 - UI에 데이터를 보유하면 안됨
    // 2. Model 변경에 대한 이벤트 구현
    // 3. View에서 Model 변경에 대한 이벤트에 변경시 UI 설정을 작업
    // (추천 : OnEnable 등록, OnDisable 해제 / Start에서 초기 설정)
    // 이 뒤부터 controller가 model의 데이터를 변경하면 => 자동으로 UI도 변경됨

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
    //    scoreText.text = $"현재 점수 : {score}";
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    score++;
    //}

}
