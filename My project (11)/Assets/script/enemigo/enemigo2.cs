using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo3 : MonoBehaviour
{
    [SerializeField] private int distance;
    private GameObject player;
    private float TimerShoot;
    private float timebetweenShots = 2f;

    [SerializeField] private GameObject spawnPoint;

    [SerializeField] private GameObject bullet;


    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    {
        TimerShoot += Time.deltaTime;

        if (Vector3.Distance(player.transform.position, transform.position) < distance)
        {
            Vector3 direction = (player.transform.position - transform.position) .normalized;
            transform.Translate(Vector3.up * Time.deltaTime);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -90f;
            transform.rotation = Quaternion.Euler(0, 0, angle);

            if (TimerShoot > timebetweenShots)
            {
                shoot();
                TimerShoot = 0;
            }
            
        }
        
    }
    protected void shoot()
        {
            Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
            
        }
}
