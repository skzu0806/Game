using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;

    public void Run()
    {
        // SetTrigger("Run") : Parameter  ���ǿ� �ִ� Trigger�� �ߵ��ϴ� �Լ��Դϴ�.
        animator.SetTrigger("Run");
    }
}
