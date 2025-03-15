using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVisual : MonoBehaviour
{
    private const string IS_RUNNING = "IsRunning";
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Vector2 moveInput = Players.Instance.GetMoveInput();
        animator.SetBool("IsRunning", Players.Instance.IsRunning());
        animator.SetFloat("MoveX", moveInput.x);
        animator.SetFloat("MoveY", moveInput .y);
    }
}
