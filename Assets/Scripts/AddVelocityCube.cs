using UnityEngine;

public class AddVelocityCube : MonoBehaviour
{
    [SerializeField] private float Velocidadcubo = 5f;
    [SerializeField] private Rigidbody Rb;

    void Start()
    {
        Rb.velocity = new Vector3(0,0,-1) * Velocidadcubo;
    }
    private void Update()
    {
        Rb.velocity = new Vector3(0, 0, -1) * Velocidadcubo;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bala")
        {
            Destroy(gameObject);
        }
    }
}
