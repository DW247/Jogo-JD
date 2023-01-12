using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptPause1 : MonoBehaviour
{
    [SerializeField] GameObject MenPa;
    [SerializeField] GameObject OpcoesEntrar;
    public int test;

    private void Start()
    {
        test = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && test == 0)
        {
            MenPa.SetActive(true);
            Time.timeScale = 0f;
            test = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && test == 1)
        {
            MenPa.SetActive(false);
            Time.timeScale = 1f;
            test = 0;
        }

         if (Input.GetKeyDown(KeyCode.Escape) && test == 1)
        {
            OpcoesEntrar.SetActive(true);
            Time.timeScale = 0f;
            test = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && test == 2)
        {
            OpcoesEntrar.SetActive(false);
            Time.timeScale = 1f;
            test = 0;
        }


    }
    public void Pause()
    {
        MenPa.SetActive(true);
        Time.timeScale = 0f;
        test = 1;
    }

    public void Opcoes()
    {
        OpcoesEntrar.SetActive(true);
        Time.timeScale = 0f;
        test = 1;
    }

    public void OpcoesVolta()
    {
        OpcoesEntrar.SetActive(false);
        Time.timeScale = 0f;
        test = 1;
    }

    public void Resume()
    {
        MenPa.SetActive(false);
        Time.timeScale = 1f;
        test = 0;
    }

    public void Home()
    {
        Time.timeScale = 1f;
        test = 0;
        SceneManager.LoadScene("MenuInicial");
        
    }

    public void cenaCreditos()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Créditos");
    }
}
