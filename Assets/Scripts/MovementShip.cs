using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementShip : MonoBehaviour
{

    [SerializeField] private PlayerInput playerInput;
    public GameObject Bocabala;
    private Rigidbody rb;
    private Vector3 inputVector;
    public float speed;
    public AudioSource Blaster;

    private void OnAttack(InputValue valor)
    {
        GameObject Bala = BocaBala.Instance.Disparar();
        Bala.transform.position = Bocabala.transform.position;
        Blaster.Play();
        
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
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
        moveChar(inputVector);
    }

    void moveChar(Vector3 direcction)
    {
        rb.velocity = inputVector * speed * Time.deltaTime;
    }

    void Attack()
    {

    }
}
