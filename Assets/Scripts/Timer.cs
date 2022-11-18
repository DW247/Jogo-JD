using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    public Text timeLevel_txt;    
    public float startTime;
    public float minute;
    public float second;
    public float secondDefault;
    public float minuteDefault;
    public int nu;
    
   
    public GameObject painel;
    // Start is called before the first frame update
    void Start()
    {
        nu = 1;
        minute = minuteDefault;
        second = secondDefault;
        timeLevel_txt.text = minute + ":" + second.ToString("00");

    }
    // Update is called once per frame
    void Update()
    {
        //if (LixoSelect.contagem == 6)
        //{
            
        //    minute = minuteDefault;
        //    second = secondDefault;
            
            
        //}

        if (minute <= 0 && second <= 0)
        {            
            minute = minuteDefault;
            second = secondDefault;
        }
        if (second > 0) 
        {
            

            second -= nu * Time.deltaTime;
            timeLevel_txt.text = minute + ":" + second.ToString("00");
        }
        else
        {
            minute--;
            second = 59;
        }


        //if (minute <= 0 && second <= 0 && LixoSelect.contagem <= 5)
        //{
        //    Telaperdeu();


        //}





    }

    private void Telaperdeu()
    {
        Time.timeScale = 0f;
        painel.SetActive(true);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo2");
        
    }
}
