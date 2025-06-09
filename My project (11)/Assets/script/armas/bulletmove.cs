using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Importar para manejar escenas

public class bulletmove : MonoBehaviour
{
    [SerializeField] private float speed; 
    // Start is called before the first frame update
    void Start()

    {
        Destroy(gameObject, 2f); // Destroy the bullet after 2 seconds to prevent memory leaks
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Idamage enemyDamage = collision.gameObject.GetComponent<Idamage>();

        if (enemyDamage != null)
        {
            enemyDamage.TakeDamage(10); // Llamar al método TakeDamage con un valor de 10
        }

        paralizar enemyParalizar = collision.gameObject.GetComponent<paralizar>();

        if (enemyParalizar != null)
        {
            enemyParalizar.paralizado();
        }
        BOX.Instace.Addscore(100); // Aumentar el puntaje al golpear un enemigo
        Debug.Log("Puntaje: " + BOX.Instace.score); // Mostrar el puntaje en la consola
        Destroy(gameObject); // Destruir la bala al colisionar
    }
}
