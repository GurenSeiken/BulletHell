using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar : MonoBehaviour
{
    [SerializeField] private float tiempo;
    [SerializeField] private float shotrate = 5f;
    [SerializeField] private bool activo = false;
    [SerializeField] private GameObject Bala1, Bala2, Bala3, Bala4,Bala5,Bala6,Bala7,Bala8,Bala9,Bala10,Bala11,Bala12,Bala13,Bala14,Bala15,Bala16;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activo)
        {
            if (Time.time > tiempo)
            {
                activo = false;
                gameObject.SetActive(false);
                Bala1.transform.position = transform.position;
                Bala2.transform.position = transform.position;
                Bala3.transform.position = transform.position;
                Bala4.transform.position = transform.position;
                Bala5.transform.position = transform.position;
                Bala6.transform.position = transform.position;
                Bala7.transform.position = transform.position;
                Bala8.transform.position = transform.position;
                Bala9.transform.position = transform.position;
                Bala10.transform.position = transform.position;
                Bala11.transform.position = transform.position;
                Bala12.transform.position = transform.position;
                Bala13.transform.position = transform.position;
                Bala14.transform.position = transform.position;
                Bala15.transform.position = transform.position;
                Bala16.transform.position = transform.position;
                tiempo = Time.time + shotrate;
            }
        }
    }
    private void OnEnable()
    {
        activo = true;
        Bala1.SetActive(true);
        Bala2.SetActive(true);
        Bala3.SetActive(true);
        Bala4.SetActive(true);
        Bala5.SetActive(true);
        Bala6.SetActive(true);
        Bala7.SetActive(true);
        Bala8.SetActive(true);
        Bala9.SetActive(true);
        Bala10.SetActive(true);
        Bala11.SetActive(true);
        Bala12.SetActive(true);
        Bala13.SetActive(true);
        Bala14.SetActive(true);
        Bala15.SetActive(true);
        Bala16.SetActive(true);
    }


}
