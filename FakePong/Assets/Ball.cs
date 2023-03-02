using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float velocidad = 300f;
    public Vector3 velocityVector;
    public float force;
    public float wallForce;
    public float enemyForce;
    public Enemigo enemigo;
    public Vector3 newDirection;
   
    // Start is called before the first frame update
    void Start()
    {
        velocityVector.z = Random.Range(-1f, 1f);
        velocityVector.y = 1f;
        rb.AddForce(velocityVector * velocidad);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            newDirection = new Vector3(0f, transform.position.y - collision.gameObject.transform.position.y, transform.position.z - collision.gameObject.transform.position.z);
            rb.AddForce(newDirection * force);
        }

        if (collision.gameObject.tag == "Wall")
        {            
            //rb.AddForce(Vector3.Reflect(new Vector3(0f, collision.gameObject.transform.position.y - transform.position.y, collision.gameObject.transform.position.z - transform.position.z), collision.contacts[0].normal) * wallForce);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            rb.AddForce(Vector3.Reflect(new Vector3(0f, collision.gameObject.transform.position.y - transform.position.y, collision.gameObject.transform.position.z - transform.position.z), collision.contacts[0].normal) * wallForce);
            //Vamos a acceder a la variable vidas que tiene el enemigo contra el que ha impactado la pelota
            //
            //
            //
            //
            //=================================== IMPORTANTE ===================================
            //Para conseguir un componente de un GameObject se usa GetComponent<TipoDeComponente>();

            collision.gameObject.GetComponent<Enemigo>().vidas--;
        }
    }
}
