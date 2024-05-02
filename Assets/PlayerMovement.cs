using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    public Rigidbody rb; // Referencia al Rigidbody del jugador
    public Camera cam; // Referencia a la cámara

    // Se llama antes de que se inicie el primer frame
    void Start()
    {
        // Obtener el Rigidbody del jugador si no se ha asignado manualmente
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        // Obtener la cámara principal si no se ha asignado manualmente
        if (cam == null)
            cam = Camera.main;
    }

    // Update se llama una vez por frame
    void FixedUpdate()
    {
        // Obtener la entrada del teclado
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calcular la dirección en la que está mirando la cámara en el plano horizontal
        Vector3 camForward = Vector3.Scale(cam.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = camForward * verticalInput + cam.transform.right * horizontalInput;

        // Aplicar el movimiento al Rigidbody del jugador
        rb.MovePosition(rb.position + moveDirection * speed * Time.fixedDeltaTime);
    }
}
