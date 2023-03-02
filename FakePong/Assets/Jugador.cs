using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Rigidbody rb;
    public float direccion;
    public float velocidadFloat;
    public Vector3 velocidadVector;


    private void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update ()
    {
        direccion = Input.GetAxisRaw("Mouse X");
        velocidadVector = new Vector3(0, 0, direccion * velocidadFloat);
        rb.AddForce(velocidadVector);
    }
}
