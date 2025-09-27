using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerHitBall : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private bool hitActionTriggered;
    private float hitCooldown; // Cooldown time in seconds

    void Awake()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();
    }

    void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Hit.performed += OnHitPerformed;
    }

    void OnDisable()
    {
        inputActions.Player.Hit.performed -= OnHitPerformed;
        inputActions.Disable();
    }

    void Start()
    {
    }

    void Update()
    {
        // If hit cooldown timer is bigger than zero, decrement it.
        if (hitCooldown > 0)
        {
            hitCooldown -= Time.deltaTime;
        }

        if (hitActionTriggered && hitCooldown <= 0)
        {
            Debug.Log("Hit the ball!");
            hitCooldown = 0.5f; // Reset cooldown after hitting
            hitActionTriggered = false; // Reset flag so holding doesn't repeat
        }

        // Debug.Log("Hit Cooldown: " + hitCooldown);
        // Debug.Log("Hit Action Triggered: " + hitActionTriggered);
    }

    private void OnHitPerformed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        if (hitCooldown <= 0)
        {
            hitActionTriggered = true;
        }
    }
}
