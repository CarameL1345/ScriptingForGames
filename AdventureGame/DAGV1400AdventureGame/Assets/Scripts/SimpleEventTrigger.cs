using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(AudioSource))]
public class SimpleEventTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    public UnityEvent triggerEvent;
    public Animator animator;
    private Collider damageCollider;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // trigger the event and test with a debug mssg
        triggerEvent.Invoke();
        animator.SetTrigger("Hit");

        audioSource.Play();
    }
}
