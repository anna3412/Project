using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int vidas;
    public Color colorVidaUno;
    public Color colorVidaDos;
    public Color colorVidaTres;
    public Color colorVidaCuatro;
    public MeshRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vidas == 0)
        {
            Destroy(this.gameObject);
        }        
        else if(vidas == 1)
        {
            rend.material.color = colorVidaUno;
        }
        else if (vidas == 2)
        {
            rend.material.color = colorVidaDos;
        }
        else if (vidas == 3)
        {
            rend.material.color = colorVidaTres;
        }
        else if (vidas == 4)
        {
            rend.material.color = colorVidaCuatro;
        }
    }
}
