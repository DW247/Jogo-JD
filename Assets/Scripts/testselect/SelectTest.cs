using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTest : MonoBehaviour
{
    public static SelectTest selectTest;
    [SerializeField]
    private bool sel;
    [SerializeField]
    public int ok;
    // Start is called before the first frame update
    void Start()
    {
        selectTest = this;
        sel = false;
        ok = 0;
    }


    public void SelecionadoAzul()
    {
        //if (sel == false && ok == 0)
        //{
            //sel = sel;
            ok = 1;
            
            print("Azul selecionada");
        //}
        //else if(sel == true)
        //{
        //    sel = !sel;
        //    ok = 0;
        //}

    }
    public void SelecionadoVermelho()
    {
        //if (sel == false && ok ==0)
        //{
            //sel = sel;
            ok = 2;
            
            print("Vermelho selecionada");
        //}
        //else if (sel == true)
        //{
        //    sel = !sel;
        //    ok = 0;
        //}

    }
    public void SelecionadoVerde()
    {
        //if (sel == false && ok == 0)
        //{
            //sel = sel;
            ok = 3;
            print("verde selecionada");
        //}
        //else if (sel == true)
        //{
        //    sel = !sel;
        //    ok = 0;
        //}

    }
    public void SelecionadoMarrom()
    {
        //if (sel == false && ok == 0)
        //{
            //sel = sel;
            ok = 4;
            print("Marrom selecionada");
        //}
        //else if (sel == true)
        //{
        //    sel = !sel;
        //    ok = 0;

        //}

    }
    public void SelecionadoCinza()
    {
        //if (sel == false && ok == 0)
        //{
            //sel = sel;
            ok = 5;
            print("Ciznza selecionada");
        //}
        //else if (sel == true)
        //{
        //    sel = !sel;
        //    ok = 0;

        //}

    }
    public void SelecionadoAmarelo()
    {
        //if (sel == false && ok == 0)
        //{
            //sel = !sel;
            ok = 6;
            print("Amarelo selecionada");
        //}
        //else if (sel == true)
        //{
        //    sel = !sel;
        //    ok = 0;

        //}

    }
}
