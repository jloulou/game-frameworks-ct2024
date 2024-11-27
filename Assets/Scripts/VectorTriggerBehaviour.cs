using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VectorTriggerBehaviour : MonoBehaviour
{
    public abstract Vector3 GetVector(); // Define a method to get a Vector3

    protected void Update()
    {
        Vector3 vector = GetVector();
        foreach (var action in GetComponents<VectorActionBehaviour>())
        {
            action.Act(vector); // Pass the Vector3 to all associated actions
        }
    }
}
