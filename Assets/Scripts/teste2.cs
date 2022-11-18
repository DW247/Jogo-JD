using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste2 : MonoBehaviour
{
    public float setValor;
    // Start is called before the first frame update
    void Start()
    {
        print("iniciou");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Teste._teste.SetPreco(setValor);
    }


}
