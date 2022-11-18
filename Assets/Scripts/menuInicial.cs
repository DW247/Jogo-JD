using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cenaJogo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo1");
    }
    public void sairJogo()
    {
        Application.Quit();
    }
}
