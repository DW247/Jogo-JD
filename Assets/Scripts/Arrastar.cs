using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanic1 : MonoBehaviour
{
    public bool segurando;
    public Vector2 mouseLoc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (segurando)
        {
            transform.position = new Vector2(mousePos.x,mousePos.y);
        }
        
    }
    public void arrastando()
    {
        segurando = !segurando;
    }

}
