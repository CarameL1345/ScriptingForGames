using UnityEngine;
using UnityEngine.Events;

public class SimpleEventTrigger : MonoBehaviour
{

    public UnityEvent triggerEvent;
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        // trigger the event and test with a debug mssg
        triggerEvent.Invoke();
        animator.SetTrigger("Hit");
    }
}
