using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MovementProvider : LocomotionProvider
{
    protected override void Awake()
    {

    }

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void PositionController()
    {
        // Get the head in local, playspace ground

        // Cut in half, add skin

        // Let's move the capsule in local space as well

        // Apply
    }

    private void CheckForInput()
    {

    }

    private void CheckForMovement(InputDevice device)
    {

    }

    private void StartMove(Vector2 position)
    {
        // Apply the touch position to the head's forward Vector

        // Rotate the input direction by the horizontal head rotation

        // Apply speed and move
    }

    private void ApplyGravity()
    {

    }
}
