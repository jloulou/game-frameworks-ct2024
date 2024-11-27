using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionVectorTrigger : VectorTriggerBehaviour
{
    [SerializeField]
    private Transform player; // Reference to the player transform
    private Vector3 initialPosition;

    private void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player Transform is not assigned.");
            enabled = false;
            return;
        }
        initialPosition = player.position; // Save initial position as reference
    }

    public override Vector3 GetVector()
    {
        return player.position - initialPosition; // Return position relative to the initial point
    }
}
