using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectTest : MonoBehaviour
{
    public static SelectTest selectTest;
    [SerializeField]
    private bool sel;
    [SerializeField]
    public int ok;
    public GameObject lixo; 
    public GameObject lixeira; 
    // Start is called before the first frame update
    void Start()
    {
        selectTest = this;
        sel = false;
        ok = 0;
    }


    //public void SelecionadoAzul()
    //{
    //        ok = 1;
    //        print("Azul selecionada");
    //}
    //public void SelecionadoVermelho()
    //{
    //        ok = 2;
    //        print("Vermelho selecionada");
    //}
    //public void SelecionadoVerde()
    //{
    //        ok = 3;
    //        print("verde selecionada");
    //}
    //public void SelecionadoMarrom()
    //{
    //        ok = 4;
    //        print("Marrom selecionada");
    //}
    //public void SelecionadoCinza()
    //{
    //        ok = 5;
    //        print("Ciznza selecionada");
       
    //}
    //public void SelecionadoAmarelo()
    //{
    //        ok = 6;
    //        print("Amarelo selecionada");
    //}
    void OnMouseDown()
    {
        
    }
    public void JogarLixo()
    {
        //if (lixo.CompareTag())
    }
}
