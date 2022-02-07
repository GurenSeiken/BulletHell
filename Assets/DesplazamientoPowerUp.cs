using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplazamientoPowerUp : MonoBehaviour
{
    [SerializeField] private float Velocidad = 5f;
    [SerializeField] private Rigidbody Power;
    void Update()
    {
        Power.velocity = Vector3.forward * Velocidad;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Pared")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
