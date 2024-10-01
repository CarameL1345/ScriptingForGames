using UnityEngine;

public class SimpleCharacterControllerTwo : MonoBehaviour
{
    public float speed = 5f;
    private CharacterController controller;
    private Vector3 velocity;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Handle movement input
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        controller.Move(move * speed * Time.deltaTime);



        // Move the character controller
        controller.Move(velocity * Time.deltaTime);
    }
}