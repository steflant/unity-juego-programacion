using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement; // Importar el espacio de nombres para SceneManager

public class reiniciar : MonoBehaviour
{
    // Método para ir al menú principal
    public void IrAlMenuPrincipal()
    {
        SceneManager.LoadScene("menu"); // Asegúrate de que "MenuPrincipal" sea el nombre correcto de la escena del menú
    }

    // Método para reiniciar la partida actual
    public void ReiniciarEscena()
    {
        string nombreEscenaActual = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nombreEscenaActual);
    }
}