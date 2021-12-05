using System.Collections.Generic;
using UnityEngine;

public class BocaBala : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    [SerializeField] private static int ArraySize = 20;
    [SerializeField] private GameObject[] Array = new GameObject[ArraySize];

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
}
