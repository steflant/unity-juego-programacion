using Assets;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enemigo : MonoBehaviour
{
    private GameObject player;
    private float speed = 2.5f;

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bulletSpawnPoint;
    [SerializeField] private float Timershoot;
    [SerializeField] private float timebetweenShoots = 2;

    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        Timershoot += Time.deltaTime;

        Vector3 direction = (player.transform.position - transform.position).normalized;

        // Rotar el enemigo para que mire hacia el jugador
        transform.LookAt(player.transform);

        // Mover al enemigo hacia el jugador
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (Timershoot > timebetweenShoots)
        {
            Shoot();
            Timershoot = 0;
        }
    }


    protected virtual void Shoot()
    {
        Instantiate(bullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    }


    private void Die()
    {
        // Aquí puedes agregar lógica para destruir al enemigo, reproducir una animación, etc.
        Destroy(gameObject);
    }
}
