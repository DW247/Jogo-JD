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
        //whatToSpawn = Random.Range(1, 7);
        //switch (whatToSpawn)
        //{
        //    case 1:
        //        GameObject.Instantiate(prefab1, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //        break;

        //    case 2:
        //        GameObject.Instantiate(prefab2, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //        break;

        //    case 3:
        //        GameObject.Instantiate(prefab3, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //        break;

        //    case 4:
        //        GameObject.Instantiate(prefab4, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //        break;

        //    case 5:
        //        GameObject.Instantiate(prefab5, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //        break;

        //    case 6:
        //        GameObject.Instantiate(prefab6, transform.position, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //        break;
        //}

        for (int i = 0; i < spawnPosition.Length; i++)
        {
            var instancia = Instantiate(prefab[Random.Range(0, prefab.Length)], spawnPosition[i].position, Quaternion.identity);
            

        }
    }



}
