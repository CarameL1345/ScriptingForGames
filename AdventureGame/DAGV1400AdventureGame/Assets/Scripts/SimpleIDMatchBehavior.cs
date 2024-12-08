using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehavior : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    public Animator animator;
    private Collider damageCollider;

    private void Start()
    {
        damageCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehavior>();

        if (otherID.id == id)
        {
            animator.SetTrigger("MatchEvent");
            damageCollider.enabled = false;
            Destroy(other.gameObject);
        }
    }
}
