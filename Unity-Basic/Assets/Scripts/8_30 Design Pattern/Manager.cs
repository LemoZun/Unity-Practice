using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Manager
{
    //Manager.cs
    public static GameManager Game { get {  return GameManager.Instance; } }
    // �ٸ� ��ũ��Ʈ���� Manager.Game ���� �Ἥ ���� ������ �Ŵ������� �������� ������


    // ���� ���۽� ���� ���� ȣ�� �� �Լ�
    // �뵵 : ���� ����, �̱���� ���� ��
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    private static void Initialize() 
    {
        GameManager.Create();
    }
}
