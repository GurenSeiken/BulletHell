using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float VelocidadBala = 5f;
    [SerializeField] private Rigidbody Balarb;

    private void OnEnable()
    {
        Balarb.velocity = Vector3.forward * VelocidadBala;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Pared")
        {
            gameObject.SetActive(false);
        }
        if (collision.transform.tag == "EnemigoChiveado") {
            gameObject.SetActive(false);
        }
    }
}
