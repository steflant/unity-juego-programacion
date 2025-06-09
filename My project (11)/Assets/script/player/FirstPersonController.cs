using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movcamara : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float sensitivity = 5.0f;
    private float rotationX = 0.0f;
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Movimiento del jugador
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        

        transform.Translate(moveX, 0, 0);

        // Rotación de la cámara
        rotationX += Input.GetAxis("Mouse X") * sensitivity;

        transform.localRotation = Quaternion.Euler(0, rotationX, 0);
        Camera.main.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
