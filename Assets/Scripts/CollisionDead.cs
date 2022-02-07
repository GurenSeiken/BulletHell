using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CollisionDead : MonoBehaviour
{

    public GameObject DeadScreen;
    public PlayableDirector Anim;
    public MovementShip Ship;
    bool power1;

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "BalaEnemiga" || collision.transform.tag == "EnemigoChiveado")
        {
            power1 = Ship.GetPowerUp1();
            
            if (power1 == false)
            {
                DeadScreen.SetActive(true);
                Anim.Play();
                yield return new WaitForSeconds(3);
                Time.timeScale = 0f;

            }


        }
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
