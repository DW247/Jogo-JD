using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider4 : MonoBehaviour
{
    public Slider mudaVolume;
    public AudioSource soundMaster;
    // Start is called before the first frame update
    void Start()
    {
        mudaVolume.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        soundMaster.GetComponent<AudioSource> ().volume = mudaVolume.value;
    }
}
