using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala3 : MonoBehaviour
{
    [SerializeField] private float VelocidadBalax;
    [SerializeField] private float VelocidadBalay;
    [SerializeField] private float VelocidadBalaz;
    [SerializeField] private Rigidbody Balarb;

    private void OnEnable()
    {
        Balarb.velocity = new Vector3(VelocidadBalax, VelocidadBalay, VelocidadBalaz);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Pared1")
        {
            gameObject.SetActive(false);
        }
        
    }
}
