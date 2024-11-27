using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VectorActionBehaviour : MonoBehaviour
{
    public abstract void Act(Vector3 vector); // Abstract method for derived actions
}

