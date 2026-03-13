using UnityEngine;

public class SimpleParticle : MonoBehaviour
{
    [HideInInspector] public float initialVelocity;
    [HideInInspector] public float initialAngle;
    [HideInInspector] public float gravity;

    [HideInInspector] public float currentLifetime;
    [HideInInspector] public float maxLifetime;

    [HideInInspector] public Vector3 initialPosition;
}