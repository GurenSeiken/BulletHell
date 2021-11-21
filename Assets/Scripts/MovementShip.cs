using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementShip : MonoBehaviour
{

    [SerializeField]private PlayerInput playerInput;
    private Rigidbody rb;
    private Vector3 inputVector;
    public float speed;

    private void OnAttack(InputValue valor) {
        Debug.Log("funciona el ataque");
    }
    private void OnMovimiento(InputValue valor) {
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

    void moveChar(Vector3 direcction) {
        //agregar velocidad en el rigit body
        //rb.AddForce(inputVector * speed * Time.deltaTime);
        rb.velocity = inputVector*speed*Time.deltaTime;
    }
}
