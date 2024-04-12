using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   public Transform player; // Referencia al transform del jugador
    public float smoothSpeed = 0.125f; // Velocidad de suavizado de movimiento de la cámara
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;

        // Establecer la posición deseada sin modificar la altura de la cámara
        Vector3 smoothedPosition = new Vector3(desiredPosition.x, transform.position.y, desiredPosition.z);

        // Suavizar el movimiento de la cámara hacia la posición deseada
        Vector3 smoothedPositionY = Vector3.Lerp(transform.position, smoothedPosition, smoothSpeed);

        // Actualizar la posición de la cámara
        transform.position = smoothedPositionY;
    }
}
