using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;


public class Selecionavel : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private AudioSource somCorreto;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerClick.layer == 7)
        {
            SelectTest.selectTest.lixeira = this.gameObject;
        }
        else
        {
            SelectTest.selectTest.lixo = transform.parent.gameObject;
        }
        SelectTest.selectTest.JogarLixo();
    }

    public void playSomCorreto()
    {
        somCorreto.Play();
    }
    
}
