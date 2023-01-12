using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ResolutionQuality : MonoBehaviour
{
    public Dropdown ddpResolution;
    public Dropdown ddpQuality;
    public Toggle tgWindow;

    private List<string> resolutions = new List<string>();
    private List<string> quality = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
        Resolution[] arrResolution = Screen.resolutions;

        foreach (Resolution r in arrResolution)
        {
            resolutions.Add(string.Format("{0} x {1}", r.width, r.height));
        }
        ddpResolution.AddOptions(resolutions);
        ddpResolution.value = (resolutions.Count - 1);

        quality = QualitySettings.names.ToList<string>();
        ddpQuality.AddOptions(quality);
        ddpQuality.value = QualitySettings.GetQualityLevel();
    }

    public void SetWindowMode()
    {
        if (tgWindow.isOn) 
            {
                Screen.fullScreen = false;
            }
        else
            {
                Screen.fullScreen = true;
            }
        }
    public void setResolution()
    {
        string[] res = resolutions[ddpResolution.value].Split('x');
        int w = Convert.ToInt16(res[0].Trim());
        int h = Convert.ToInt16(res[1].Trim());
        Screen.SetResolution(w, h, Screen.fullScreen);
    }

    public void setQuality()
    {
        QualitySettings.SetQualityLevel(ddpQuality.value, true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}

    

