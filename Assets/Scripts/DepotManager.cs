using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepotManager : MonoBehaviour
{
    public GameObject []slots;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Additem(GameObject[]itens)
    {
        for(int i = 0; i < itens.Length; i++)
        {
            slots[i] = itens[i];
        }
    }
}
