using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Manager
{
    //Manager.cs
    public static GameManager Game { get {  return GameManager.Instance; } }
    // 다른 스크립트에서 Manager.Game 으로 써서 무슨 역할의 매니저인지 직관성이 높아짐


    // 게임 시작시 가장 먼저 호출 될 함수
    // 용도 : 게임 설정, 싱글톤들 정리 등
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]

    private static void Initialize() 
    {
        GameManager.Create();
    }
}
