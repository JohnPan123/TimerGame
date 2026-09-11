using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLogic : MonoBehaviour
{
    public Animator jawAnimator;
    private InputAction movementInput;
    private Rigidbody2D playerRB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movementInput = InputSystem.actions.FindAction("Position");
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (TurnSensorLogic.NoFoodInMouth())
            PlayerRotation();
        else
            playerRB.angularVelocity = angularSpeed * Mathf.DeltaAngle(playerRB.rotation , targetAngle);
    }
    private float targetAngle = 0f;
    private float angularSpeed = 20f;
    private Vector2 rotationInput;
    private void PlayerRotation()
    {
        rotationInput = movementInput.ReadValue<Vector2>();
        
        if (rotationInput.x == 1)
            targetAngle = 0;

        else if (rotationInput.x == -1)
            targetAngle = 180f;

        else if (rotationInput.y == 1)
            targetAngle = 90f;

        else if (rotationInput.y == -1)
            targetAngle = 270f;

        playerRB.angularVelocity = angularSpeed * Mathf.DeltaAngle(playerRB.rotation , targetAngle);
    }
}
