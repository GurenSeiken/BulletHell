using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{

    [SerializeField] private GameObject BalaPrefab;
    [SerializeField] private static int ArraySize = 220;
    [SerializeField] private GameObject[] Array = new GameObject[ArraySize];
    [SerializeField] private GameObject Escudo;
    public GameObject WinWIn;

    float time, TimeDelay;

    public GameObject Disparar()
    {
        for (int i = 0; i < ArraySize; i++)
        {
            if (!Array[i].activeSelf)       //Verificamos que el elemento no este activo
            {
                Array[i].SetActive(true);
                return Array[i];
            }
        }
        return null;
    }

    public GameObject Bocabala;
    public GameObject self;
    public GameObject Pos1, Pos2;
    public bool powerup1 = false;
    public bool powerup2 = false;
    bool powerup3 = false;
    public Text Vida;
    float life = 100;
    public int N;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.transform.tag == "Bala")
        {
            life = life - 1;
            setVidaText();
        }
    }

    void setVidaText() {
        Vida.text = life.ToString();
    }


    int selector() {
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

    // Update is called once per frame
    void Update()
    {
        if (life < 0) {
            WinWIn.SetActive(true);
        }
    }

    public void SetEscudoOn()
    {
        Escudo.SetActive(true);
    }

    public void SetEscudoOff()
    {
        Escudo.SetActive(false);
    }
}
