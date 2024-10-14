using UnityEngine;
using UnityEngine.Events;

public class SimpleEventTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        // trigger the event and test with a debug mssg
        triggerEvent.Invoke();
        Debug.Log("Player interacted with the object");
    }
}
