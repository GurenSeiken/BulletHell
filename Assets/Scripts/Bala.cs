using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float VelocidadBalax ;
    [SerializeField] private float VelocidadBalay ;
    [SerializeField] private float VelocidadBalaz ;
    [SerializeField] private Rigidbody Balarb;

    private void OnEnable()
    {
        Balarb.velocity = new Vector3(VelocidadBalax, VelocidadBalay, VelocidadBalaz);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Pared")
        {
            gameObject.SetActive(false);
        }
        if (collision.transform.tag == "EnemigoChiveado")
        {
            gameObject.SetActive(false);
        }
        if (collision.transform.tag == "Pared1")
        {
            gameObject.SetActive(false);
        }
    }
}
