using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

public class enemigorojo : enemigo, paralizar, Idamage
{
    private bool isparalizado = false;
    [SerializeField] private float timeparalized = 3f; // Tiempo de paralisis en segundos
    [SerializeField] private int health4 = 1500; // Salud del enemigo
    


    public void paralizado()
    {
        isparalizado = true;
        Debug.Log("El enemigo ha sido paralizado");
        Invoke("deparalize", timeparalized); // Llama a deparalize después de 3 segundos
    }
    protected override void Update()
    {
        if (!isparalizado)
        {
            base.Update();
        }
        
    }
    public void deparalize()
    {
        isparalizado = false;
        Debug.Log("El enemigo ha sido liberado de la paralisis");
    }

    public void TakeDamage(int damage)
    {
        health4 -= damage; // Resta la cantidad de daño a la salud del enemigo
        Debug.Log("El enemigo ha recibido daño. Salud restante: " + health4);
    
        if (health4 <= 0)
        {
            Destroy(gameObject); // Destruir el enemigo si su salud llega a 0
            Debug.Log("El enemigo ha sido destruido.");
            UnityEngine.SceneManagement.SceneManager.LoadScene("VictoryScreen"); // Cargar la pantalla de victoria
            
            // Reactivar el cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    
    
}
