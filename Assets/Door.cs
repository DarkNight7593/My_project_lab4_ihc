using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float rotationSpeed = 90f; // velocidad de giro
    private bool isOpening = false;

    void Update()
    {
        // Detecta botón A del control derecho (Oculus)
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            isOpening = !isOpening; // alterna abrir/cerrar
        }

        if (isOpening)
        {
            // rota la puerta suavemente
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                Quaternion.Euler(0, 90, 0), // ángulo abierto
                rotationSpeed * Time.deltaTime
            );
        }
        else
        {
            // vuelve a posición inicial
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                Quaternion.Euler(0, 0, 0),
                rotationSpeed * Time.deltaTime
            );
        }
    }
}