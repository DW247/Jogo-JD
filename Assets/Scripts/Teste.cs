using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public static Teste _teste;
    [SerializeField]
    private float preco;

    private void Awake()
    {
        _teste = this;
    }

    public void SetPreco(float _preco)
    {
        if (_preco <= 0)
        {
            print("O preço está errado");
        }
        else
        {
            this.preco = _preco;
        }
    }
}
