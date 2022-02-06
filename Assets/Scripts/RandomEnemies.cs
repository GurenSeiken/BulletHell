using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemies : MonoBehaviour
{
    [SerializeField] static int NumOfSpawns;
    [SerializeField] GameObject[] Posiciones=new GameObject[NumOfSpawns];
    [SerializeField] private GameObject player;
    public GameObject[] path;
    Vector3[] LocalizacionPosiciones=new Vector3[NumOfSpawns];
    public GameObject Enemie;
    float time, TimeDelay;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        TimeDelay = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;
        if (time >= TimeDelay) {
            time = 0f;
            SpawnOfEnemies(Seleccion());
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

    void SpawnOfEnemies(int Num) {
        GameObject Enemiee = Instantiate(Enemie) as GameObject;
        if (Num==1)
        {
            
            Enemiee.transform.position = Posiciones[0].transform.position;
            Enemiee.GetComponent<EnemyAI>().playerTransform = path[1].transform;
          
        }
        else if (Num==2)
        {
            
            Enemiee.transform.position = Posiciones[1].transform.position;
            Enemiee.GetComponent<EnemyAI>().playerTransform = path[2].transform;

        }
        else
        {
            
            Enemiee.transform.position = Posiciones[2].transform.position;
            Enemiee.GetComponent<EnemyAI>().playerTransform = path[0].transform;

        }
    
    }
     
}
