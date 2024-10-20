using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Cache the Animator component attached to CharacterArt
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }
    }
}
