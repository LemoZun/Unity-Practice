using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUITester : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] bool show;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            show = !show;
            animator.SetBool("Show",show);
        }
    }
}
