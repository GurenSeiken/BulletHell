using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementShip : MonoBehaviour
{

    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private GameObject Escudo;
    public GameObject Bocabala;
    private Rigidbody rb;
    private Vector3 inputVector;
    public float speed;
    public AudioSource Blaster;



    public bool powerup1 = false;
    public bool powerup2 = false;
    public bool powerup3 = false;
    float time, TimeDelay;

    private void OnAttack(InputValue valor)
    {
        if (powerup2==false && powerup3 == false)
        {
            GameObject Bala = BocaBala.Instance.Disparar();
            Bala.transform.position = Bocabala.transform.position;
            Blaster.Play();
        }
        else if (powerup2 == true)
        {
            GameObject Bala = BocaBala.Instance.Disparar2();
            Bala.transform.position = Bocabala.transform.position;
            Blaster.Play();
        }else if (powerup3 == true)
        {
            GameObject Bala = BocaBala.Instance.Disparar3();
            Bala.transform.position = Bocabala.transform.position;
            Blaster.Play();
        }


    }
    private void OnMovimiento(InputValue valor)
    {
        Vector2 inputMov = valor.Get<Vector2>();
        inputVector = new Vector3(inputMov.x, 0, inputMov.y);

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        time = 0f;
        TimeDelay = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (powerup1 || powerup2 || powerup3 == true)
        {
            if (powerup1 == true)
            {
                Escudo.SetActive(true);
                time = time + 1f * Time.deltaTime;
                if (time >= TimeDelay)
                {
                    time = 0f;
                    powerup1 = false;
                    Escudo.SetActive(false);
                }
            }
            if (powerup2 == true)
            {

                powerup3 = false;
                time = time + 1f * Time.deltaTime;
                if (time >= TimeDelay)
                {
                    time = 0f;
                    powerup2 = false;
                }
            }
            if (powerup3 == true)
            {
                powerup2 = false;

                time = time + 1f * Time.deltaTime;
                if (time >= TimeDelay)
                {
                    time = 0f;
                    powerup3 = false;
                }
            }
        }
    }
    void FixedUpdate()
    {
        moveChar(inputVector);
    }

    void moveChar(Vector3 direcction)
    {
        rb.velocity = inputVector * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Powerup1")
        {
            if (powerup1 || powerup2 || powerup3)
            {
                time = 0;
            }
            powerup1 = true;
        }
        if (collision.transform.tag == "Powerup2")
        {
            if (powerup1 || powerup2 || powerup3)
            {
                time = 0;
            }
            powerup2 = true;
        }
        if (collision.transform.tag == "Powerup3")
        {
            if (powerup1 || powerup2 || powerup3)
            {
                time = 0;
            }
            powerup3 = true;
        }
    }
    public bool GetPowerUp1() {
        return powerup1;
    }


}
