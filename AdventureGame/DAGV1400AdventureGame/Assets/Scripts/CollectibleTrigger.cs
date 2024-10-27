using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class CollectibleTrigger : MonoBehaviour
{

    public UnityEvent triggerEvent;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        // trigger the event and test with a debug mssg
        triggerEvent.Invoke();
        
        StartCoroutine(PlayAnimationAndDestroy());
    }

    private IEnumerator PlayAnimationAndDestroy()
    {
        // Trigger the animation
        animator.SetTrigger("Collected");

        // Wait for the animation to complete (adjust the duration as necessary)
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        // Destroy the object after the animation
        Destroy(gameObject);
    }
}