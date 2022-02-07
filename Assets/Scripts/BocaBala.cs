using System.Collections.Generic;
using UnityEngine;

public class BocaBala : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    [SerializeField] private GameObject BalaPrefab1;
    [SerializeField] private GameObject BalaPrefab2;
    [SerializeField] private GameObject BalaPrefab3;
    [SerializeField] private static int ArraySize = 20;
    [SerializeField] private GameObject[] Array = new GameObject[ArraySize];
    [SerializeField] private GameObject[] Array1 = new GameObject[ArraySize];
    [SerializeField] private GameObject[] Array2 = new GameObject[ArraySize];
    [SerializeField] private GameObject[] Array3 = new GameObject[ArraySize];

    private static BocaBala instance;
    public static BocaBala Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        for (int i = 0; i< ArraySize; i++)
        {
            GameObject Bala = Instantiate(BalaPrefab);
            Bala.SetActive(false);
            Array[i] = Bala;
            Bala.transform.parent = transform;
        }
        for (int i = 0; i < ArraySize; i++)
        {
            GameObject Bala1 = Instantiate(BalaPrefab1);
            Bala1.SetActive(false);
            Array1[i] = Bala1;
            Bala1.transform.parent = transform;
        }
        for (int i = 0; i < ArraySize; i++)
        {
            GameObject Bala2 = Instantiate(BalaPrefab2);
            Bala2.SetActive(false);
            Array2[i] = Bala2;
            Bala2.transform.parent = transform;
        }
        for (int i = 0; i < ArraySize; i++)
        {
            GameObject Bala3 = Instantiate(BalaPrefab3);
            Bala3.SetActive(false);
            Array3[i] = Bala3;
            Bala3.transform.parent = transform;
        }
    }

    public GameObject Disparar()
    {
        for (int i = 0; i<ArraySize; i++)
        {
            if (!Array[i].activeSelf)       //Verificamos que el elemento no este activo
            {
                Array[i].SetActive(true);
                return Array[i];
            }
        }
        return null;
    }
    public GameObject Disparar1()
    {
        for (int i = 0; i < ArraySize; i++)
        {
            if (!Array1[i].activeSelf)       //Verificamos que el elemento no este activo
            {
                Array1[i].SetActive(true);
                return Array1[i];
            }
        }
        return null;
    }
    public GameObject Disparar2()
    {
        for (int i = 0; i < ArraySize; i++)
        {
            if (!Array2[i].activeSelf)       //Verificamos que el elemento no este activo
            {
                Array2[i].SetActive(true);
                
                return Array2[i];
            }
        }
        return null;
    }
    public GameObject Disparar3()
    {
        for (int i = 0; i < ArraySize; i++)
        {
            if (!Array3[i].activeSelf)       //Verificamos que el elemento no este activo
            {
                Array3[i].SetActive(true);
                return Array3[i];
            }
        }
        return null;
    }
}
