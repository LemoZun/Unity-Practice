using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour// , IInteractable //인터페이스가 없는 상황엔? 어댑터
{

    public void TargetInteract(Player player)
    {
        Use();
    }    

    public void Use()
    {
        Debug.Log("아이템 사용!");
        Destroy(gameObject);
    }
}
