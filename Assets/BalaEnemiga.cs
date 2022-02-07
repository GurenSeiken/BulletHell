using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemiga : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Pared")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Pared1")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Escudo")
        {
            Destroy(gameObject);
        }
        if (collision.transform.tag == "Mina")
        {
            Destroy(gameObject);
        }
    }
}
