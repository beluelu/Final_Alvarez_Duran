using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public float velocidadRotacion = 50f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, velocidadRotacion * Time.fixedDeltaTime, 0f));
    }
}
