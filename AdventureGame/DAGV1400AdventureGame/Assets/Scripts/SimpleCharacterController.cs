using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 3f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;

    public SimpleFloatData staminaData;
    public SimpleImageBehavior staminaUI;


    // private Vector3 movementVector = Vector3.zero;

    private void Start()
    {
        // cache refs to components
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            Debug.Log("Jump");
            staminaData.UpdateValue(-0.1f);
        }

        //Debug.Log(controller.isGrounded);

        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        RegenerateStamina();
        UpdateStaminaUI();
    }
   
    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);
    }

    private void ApplyGravity()
    {
        velocity.y += gravity * Time.deltaTime;

        // apply velocity to controller
        controller.Move(velocity * Time.deltaTime);
    }

    private void RegenerateStamina()
    {
        if(staminaData != null && Mathf.Approximately(staminaData.value, 1) == false)
        {
            staminaData.UpdateValue(0.03f * Time.deltaTime);
        }
    }

    private void UpdateStaminaUI()
    {
        if (staminaUI != null)
        {
            staminaUI.UpdateWithFloatData();
        }
    }

    private void KeepCharacterOnXAxis()
    {
        // use cached transform ref and optimize vector creation
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

}

