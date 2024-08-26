using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    // Start is called before the first frame update


    private void Awake()
    {
        Debug.Log("Awake 메서드 실행");
    }

    void Start()
    {
        Debug.Log("Start 메서드 실행");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable 메서드 실행");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable 메서드 실행");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update 메서드 실행");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy 메서드 실행");
    }

    // 데이터 직렬화, 지원되는 타입

    // c# 타입
    public bool boolType;
    public int intType;
    public float floatType;
    public string stringType;

    // Unity 타입
    public Vector2 vector2;
    public Vector3 vector3;

    // 소수점 불가능한 벡터값
    public Vector2Int intVector2;
    public Vector3Int intVector3;

    public Color color;

    public Rect rect;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;
 
    // 열거형
    public enum JobType { Warrior, Mage, Baba}
    public JobType jobType;

    //배열 기반 자료구조
    public int[] array;
    public List<int> list;

    public Rigidbody rigid;
    public Collider coll;

    // 어트리뷰트

    [Space(30)] // 여백을 추가

    [Header("InputHeader")] // 헤더를 추가

    [SerializeField] private int privateValue; //private지만 인스펙터에서 조작하고싶은경우

    [HideInInspector] public int publicValue; //public이지만 인스펙터에서 조작을 막고싶은경우

    [Range(3, 5)]
    public float percent; // 범위를 지정해주고 싶은 경우 인스펙터에서 슬라이더로 표현됨

    [TextArea(3,5)]
    public string story; //최소 줄 수와 최대 줄 수를 지정해 긴 문자열을 인스펙터에서 입력 가능

    //원래 구조체와 클래스는 인스펙터상에서 수정 불가능, Serializable로 가능하게 만들 수 있다.
    [System.Serializable]
    public struct Data 
    {
        public string name;
        public int level;
        public float rate;
    }
    public Data data;


}
