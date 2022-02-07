using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemies : MonoBehaviour
{
    [SerializeField] static int NumOfSpawns;
    [SerializeField] GameObject[] Posiciones=new GameObject[NumOfSpawns];
    [SerializeField] private GameObject player;
    Vector3[] LocalizacionPosiciones=new Vector3[NumOfSpawns];
    public GameObject Powerup1;
    public GameObject Powerup2;
    public GameObject Powerup3;
    public GameObject Enemie;
    public bool CanSpawn = true;
    float time, TimeDelay, timepowers;

    int pos;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        TimeDelay = 3f;
        timepowers = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanSpawn == true)
        {
            time = time + 1f * Time.deltaTime;
            timepowers = time + 1f * Time.deltaTime;
            if (time >= TimeDelay)
            {
                time = 0f;
                SpawnOfEnemies(Seleccion());
                SpawnofPowers(powers(), pos);
            }
            if (timepowers >= TimeDelay + 5f)
            {
                timepowers = 0f;
                time = 0f;
                SpawnofPowers(powers(), pos);
            }
        }

    }

    public int Seleccion() {
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

    public int powers()
    {
        int poss = Random.Range(0, 3);
        int pow = Random.Range(0,300);
        pos = Random.Range(0, 2);
        if (poss==1)
        {
            if (pow < 100)
            {
                return 1;
            }
            if (pow < 200 && pow > 100)
            {
                return 2;
            }
            if (pow > 200)
            {
                return 3;
            }
            return 0;
        }
        return 0;
    }

    void SpawnOfEnemies(int Num) {

        if (Num==1)
        {
            GameObject Enemiee = Instantiate(Enemie) as GameObject;
            Enemiee.transform.position = Posiciones[0].transform.position;
            Enemiee.GetComponent<EnemyAI>().playerTransform = player.transform;
          
        }
        if (Num==2)
        {
            GameObject Enemiee = Instantiate(Enemie) as GameObject;
            Enemiee.transform.position = Posiciones[1].transform.position;
            Enemiee.GetComponent<EnemyAI>().playerTransform = player.transform;
        }
        if (Num==3)
        {
            GameObject Enemiee = Instantiate(Enemie) as GameObject;
            Enemiee.transform.position = Posiciones[2].transform.position;
            Enemiee.GetComponent<EnemyAI>().playerTransform = player.transform;
        }

    }

    void SpawnofPowers(int power, int pos)
    {
        if (power==1)
        {
            if (pos==0)
            {
                GameObject Powerup10 = Instantiate(Powerup1) as GameObject;
                Powerup10.transform.position = Posiciones[0].transform.position;
            }else if (pos==1)
            {
                GameObject Powerup10 = Instantiate(Powerup1) as GameObject;
                Powerup10.transform.position = Posiciones[1].transform.position;
            }else if (pos==2)
            {
                GameObject Powerup10 = Instantiate(Powerup1) as GameObject;
                Powerup10.transform.position = Posiciones[2].transform.position;
            }
            
        }else if (power == 2)
        {
            if (pos == 0)
            {
                GameObject Powerup20 = Instantiate(Powerup2) as GameObject;
                Powerup20.transform.position = Posiciones[0].transform.position;
            }
            else if (pos == 1)
            {
                GameObject Powerup20 = Instantiate(Powerup2) as GameObject;
                Powerup20.transform.position = Posiciones[1].transform.position;
            }
            else if (pos == 2)
            {
                GameObject Powerup20 = Instantiate(Powerup2) as GameObject;
                Powerup20.transform.position = Posiciones[2].transform.position;
            }
        }
        else if (power == 3)
        {
            if (pos == 0)
            {
                GameObject Powerup30 = Instantiate(Powerup3) as GameObject;
                Powerup30.transform.position = Posiciones[0].transform.position;
            }
            else if (pos == 1)
            {
                GameObject Powerup30 = Instantiate(Powerup3) as GameObject;
                Powerup30.transform.position = Posiciones[1].transform.position;
            }
            else if (pos == 2)
            {
                GameObject Powerup30 = Instantiate(Powerup3) as GameObject;
                Powerup30.transform.position = Posiciones[2].transform.position;
            }
        }
    }


}
