using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LixoSelect : MonoBehaviour
{
    [SerializeField]
    private string _tag;
  
    //public int lixoAzul;
    //public int lixoVermelho;
    //public int lixoVerde;
    //public int lixoMarrom;
    //public int lixoCinza;
    //public int lixoAmarelo;
    //public int dadosOk;
    //[SerializeField]
    //public static int contagem;
  

    
    
    // Start is called before the first frame update
    void Start()
    {   
        //contagem = 0;
        //lixoAzul = 0;
        //lixoVermelho = 0;
        //lixoVerde = 0;
        //lixoMarrom = 0;
        //lixoCinza = 0;
        //lixoAmarelo = 0;
}

    // Update is called once per frame
    //void Update()
    //{
    //    dadosOk = SelectTest.selectTest.ok;
    //    if (SelectTest.selectTest.ok == 1 && lixoAzul == 1)
    //    {
    //        contagem++;
    //        print("ok");
    //        Destroy(gameObject);
    //    }
    //    else if (SelectTest.selectTest.ok == 2 && lixoVermelho == 2)
    //    {
    //        contagem++;
    //        print("ok");
    //        Destroy(gameObject);
    //    }
    //    else if (SelectTest.selectTest.ok == 3 && lixoVerde == 3)
    //    {
    //        contagem++;
    //        print("ok");
    //        Destroy(gameObject);
    //    }
    //    else if (SelectTest.selectTest.ok == 4 && lixoMarrom == 4)
    //    {
    //        contagem++;
    //        print("ok");
    //        Destroy(gameObject);
    //    }
    //    else if (SelectTest.selectTest.ok == 5 && lixoCinza == 5)
    //    {
    //        contagem++;
    //        print("ok");
    //        Destroy(gameObject);
    //    }
    //    else if (SelectTest.selectTest.ok == 6 && lixoAmarelo == 6)
    //    {
    //        contagem++;
    //        print("ok");
    //        Destroy(gameObject);
    //    }
    //}
    //public void SelecionadoAzul()
    //{
    //    if(lixoAzul == 0)
    //    {
    //        lixoAzul = 1;
    //    }
    //    else if(lixoAzul == 1)
    //    {
    //        lixoAzul = 0;
    //    }
    //}
    //public void SelecionadoVermelho()
    //{
    //    if (lixoVermelho == 0)
    //    {
    //        lixoVermelho = 2;
    //    }
    //    else if (lixoVermelho == 2)
    //    {
    //        lixoVermelho = 0;
    //    }
    //}
    //public void SelecionadoVerde()
    //{
    //    if (lixoVerde == 0)
    //    {
    //        lixoVerde = 3;
    //    }
    //    else if (lixoVerde == 3)
    //    {
    //        lixoVerde = 0;
    //    }
    //}
    //public void SelecionadoMarrom()
    //{
    //    if (lixoMarrom == 0)
    //    {
    //        lixoMarrom = 4;
    //    }
    //    else if (lixoMarrom == 4)
    //    {
    //        lixoMarrom = 0;
    //    }
    //}
    //public void SelecionadoCinza()
    //{
    //    if (lixoCinza == 0)
    //    {
    //        lixoCinza = 5;
    //    }
    //    else if (lixoCinza == 5)
    //    {
    //        lixoCinza = 0;
    //    }
    //}
    //public void SelecionadoAmarelo()
    //{
    //    if (lixoAmarelo == 0)
    //    {
    //        lixoAmarelo = 6;
    //    }
    //    else if (lixoAmarelo == 6)
    //    {
    //        lixoAmarelo = 0;
    //    }
    //}

    public void OnMouseDown()
    {
        _tag = gameObject.tag;
        print(_tag);
    }


}
