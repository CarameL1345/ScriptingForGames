using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    public string playerTag = "Player"; // The tag assigned to the player GameObject

    public void OnTriggerEnter(Collider other)
    {
        // Check if the collided GameObject has the player tag
        if (other.CompareTag(playerTag))
        {
            transform.parent = other.transform;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        // Detach only if the exiting GameObject is the player
        if (other.CompareTag(playerTag))
        {
            transform.parent = null;
        }
    }
}
