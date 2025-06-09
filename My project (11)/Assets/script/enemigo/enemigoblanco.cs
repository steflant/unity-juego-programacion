using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

public class enemigoblanco : enemigo, Idamage
{
    [SerializeField] private int health2 = 25; // Salud del enemigo
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health2 -= damage; // Resta la cantidad de daño a la salud del enemigo
        Debug.Log("El enemigo ha recibido daño. Salud restante: " + health2);
    
        if (health2 <= 0)
        {
            Destroy(gameObject); // Destruir el enemigo si su salud llega a 0
            Debug.Log("El enemigo ha sido destruido.");
        }
    }
   
}
