using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour// , IInteractable //�������̽��� ���� ��Ȳ��? �����
{

    public void TargetInteract(Player player)
    {
        Use();
    }    

    public void Use()
    {
        Debug.Log("������ ���!");
        Destroy(gameObject);
    }
}
