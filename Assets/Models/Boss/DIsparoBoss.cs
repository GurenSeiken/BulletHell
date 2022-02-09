using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIsparoBoss : MonoBehaviour
{
    [SerializeField] public GameObject Bala;
    [SerializeField] public GameObject Bala1;
    [SerializeField] public GameObject Bala2;
    [SerializeField] private Transform boca;

    [SerializeField] private float velocidad = 5f;
    [SerializeField] private float shotrate = 0.5f;
    [SerializeField] private float tiempo;
    int N;


    void Update()
    {
        N = selector();
        if (Time.time > tiempo)
        {

            if (N == 1) {
                GameObject bala;
                bala = Instantiate(Bala, boca.position, boca.rotation);
                bala.GetComponent<Rigidbody>().AddForce(boca.forward * velocidad);
                tiempo = Time.time + shotrate;
                Destroy(bala, 1f);
            }
            if (N == 2) {
                GameObject bala;
                bala = Instantiate(Bala2, boca.position, boca.rotation);
                bala.GetComponent<Rigidbody>().AddForce(boca.forward * velocidad);
                tiempo = Time.time + shotrate;
                Destroy(bala, 1f);
            }

            
        }
    }

    int selector()
    {
        int num;
        num = Random.Range(0, 300);

        if (num < 100)
        {
            return 1;
        }
        if (num < 200 && num > 100)
        {
            return 2;
        }
        if (num > 200)
        {
            return 3;
        }
        return 0;
    }
}
