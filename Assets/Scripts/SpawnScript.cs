using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    //public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6;
    public GameObject[] prefab;
    public Transform[] spawnPosition;
    public DepotManager array;
    int whatToSpawn;
    public Timer timer;

    private void Start()
    {
        Spawnar();
    }
    void Update()
    {
        //if (timer.minute <= 0 && timer.second <= 00)
        //{
        //    Spawnar();
        //}
    }

    void Spawnar()
    {
        for (int i = 0; i < spawnPosition.Length; i++)
        {
            var instancia = Instantiate(prefab[Random.Range(0, prefab.Length)], spawnPosition[i].position, Quaternion.identity);
            instancia.transform.SetParent(this.transform);
        }
    }



}
