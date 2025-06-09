using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmoveenemi : MonoBehaviour
{
    [SerializeField] private float speed = 10f; // Speed of the bullet
    // Start is called before the first frame update
    void Start()

    {
        Destroy(gameObject, 2f); // Destroy the bullet after 2 seconds to prevent memory leaks
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    
}
