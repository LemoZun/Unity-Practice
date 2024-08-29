using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponent : MonoBehaviour
{
    // Start is called before the first frame update


    private void Awake()
    {
        Debug.Log("Awake �޼��� ����");
    }

    void Start()
    {
        Debug.Log("Start �޼��� ����");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable �޼��� ����");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable �޼��� ����");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update �޼��� ����");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy �޼��� ����");
    }

    // ������ ����ȭ, �����Ǵ� Ÿ��

    // c# Ÿ��
    public bool boolType;
    public int intType;
    public float floatType;
    public string stringType;

    // Unity Ÿ��
    public Vector2 vector2;
    public Vector3 vector3;

    // �Ҽ��� �Ұ����� ���Ͱ�
    public Vector2Int intVector2;
    public Vector3Int intVector3;

    public Color color;

    public Rect rect;
    public LayerMask layerMask;
    public AnimationCurve curve;
    public Gradient gradient;
 
    // ������
    public enum JobType { Warrior, Mage, Baba}
    public JobType jobType;

    //�迭 ��� �ڷᱸ��
    public int[] array;
    public List<int> list;

    public Rigidbody rigid;
    public Collider coll;

    // ��Ʈ����Ʈ

    [Space(30)] // ������ �߰�

    [Header("InputHeader")] // ����� �߰�

    [SerializeField] private int privateValue; //private���� �ν����Ϳ��� �����ϰ�������

    [HideInInspector] public int publicValue; //public������ �ν����Ϳ��� ������ ����������

    [Range(3, 5)]
    public float percent; // ������ �������ְ� ���� ��� �ν����Ϳ��� �����̴��� ǥ����

    [TextArea(3,5)]
    public string story; //�ּ� �� ���� �ִ� �� ���� ������ �� ���ڿ��� �ν����Ϳ��� �Է� ����

    //���� ����ü�� Ŭ������ �ν����ͻ󿡼� ���� �Ұ���, Serializable�� �����ϰ� ���� �� �ִ�.
    [System.Serializable]
    public struct Data 
    {
        public string name;
        public int level;
        public float rate;
    }
    public Data data;


}
