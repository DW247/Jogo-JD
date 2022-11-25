using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


public class SelectTest : MonoBehaviour
{
    public static SelectTest selectTest;
    //private bool sel;
    //[SerializeField]
    public int ok;
    public LayerMask lixoLayer;
    public LayerMask lixeiraLayer;
    public GameObject lixo; 
    public GameObject lixeira; 
    // Start is called before the first frame update
    void Start()
    {
              
        ok = 0;
    }
    private void Awake()
    {
        selectTest = this;
    }

    private void Update()
    {
        if (EventSystem.current.gameObject.layer == 7) 
        {
            lixeira = EventSystem.current.gameObject; 
        
        }
    }
    public void JogarLixo()
    {
       if(lixeira != null && lixo != null)
        {
            if (lixeira.CompareTag(lixo.tag))
            {
                Destroy(lixo);
                lixo = null;
                lixeira = null;
            }
        }
    }

}
