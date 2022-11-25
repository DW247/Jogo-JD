using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Selecionavel : MonoBehaviour, IPointerClickHandler
{
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

    
}
