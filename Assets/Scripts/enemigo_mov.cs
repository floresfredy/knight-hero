using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo_mov : MonoBehaviour

{
    public float speed;
    public bool esDerecha;
    public float contadorT;
    public float tiempoCambiar = 4f;

    

    
    // Start is called before the first frame update
    void Start()
    {
        contadorT = tiempoCambiar;
    }

    // Update is called once per frame
    void Update()
    {
        if(esDerecha == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(1,1,1);
        }
        if(esDerecha == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.localScale = new Vector3(-1,1,1);

        }

        contadorT -= Time.deltaTime;
        if(contadorT <= 0)
        {
            contadorT = tiempoCambiar;
            esDerecha = !esDerecha;
        }
        
    }

    

}
