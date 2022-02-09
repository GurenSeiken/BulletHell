using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] public GameObject Bala;
    [SerializeField] private Transform boca;

    [SerializeField] private float velocidad ;
    [SerializeField] private float shotrate = 0.5f;
    [SerializeField] private float tiempo;




    

    void Update()
    {

        if (Time.time>tiempo)
        {
            GameObject bala;
            bala = Instantiate(Bala,boca.position,boca.rotation);
            bala.GetComponent<Rigidbody>().AddForce(boca.forward*velocidad);
            tiempo = Time.time + shotrate;
            
            Destroy(bala,1f);
        }
    }
    
}
