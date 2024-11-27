using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightColorVectorAction : VectorActionBehaviour
{
    [SerializeField]
    private float redScale = 1.0f;
    [SerializeField]
    private float greenScale = 1.0f;
    [SerializeField]
    private float blueScale = 1.0f;

    private Light lightComponent;

    private void Start()
    {
        lightComponent = GetComponent<Light>();
        if (lightComponent == null)
        {
            Debug.LogError("Light component not found.");
            enabled = false;
        }
    }

    public override void Act(Vector3 vector)
    {
        // Scale the player's position values for RGB
        float red = Mathf.Clamp01(vector.x * redScale);
        float green = Mathf.Clamp01(vector.y * greenScale);
        float blue = Mathf.Clamp01(vector.z * blueScale);

        // Set the light color
        lightComponent.color = new Color(red, green, blue);
    }
}
