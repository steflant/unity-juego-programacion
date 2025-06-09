using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    [SerializeField] private GameObject [] enemys;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnEnemy", 15, 2); // Call SpawnEnemy every 2 seconds
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnEnemy()
    {
        int random = Random.Range(0, enemys.Length); // Get a random index for the enemy array
        Instantiate(enemys[random], transform.position, Quaternion.identity);
    }
}
