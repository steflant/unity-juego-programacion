using System.Collections;
using System.Collections.Generic;
using Assets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // Importar para manejar escenas

public class enemigonegro : enemigo, Idamage
{
    [SerializeField] private int health3 = 50; // Salud del enemigo

    public void TakeDamage(int damage)
    {
        health3 -= damage; // Resta la cantidad de daño a la salud del enemigo
        Debug.Log("El enemigo ha recibido daño. Salud restante: " + health3);
    
        if (health3 <= 0)
        {
            Destroy(gameObject); // Destruir el enemigo si su salud llega a 0
            Debug.Log("El enemigo ha sido destruido.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Verificar si colisiona con el jugador
        {
            Cursor.lockState = CursorLockMode.None; // Desbloquear y activar el cursor
            Cursor.visible = true; // Hacer visible el cursor
            SceneManager.LoadScene("Derrota"); // Cambiar a la escena de derrota
            Debug.Log("El jugador ha colisionado con el enemigo. Escena de derrota cargada.");
        }
    }
}
