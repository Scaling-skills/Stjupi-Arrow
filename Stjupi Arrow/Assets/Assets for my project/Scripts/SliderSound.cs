using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderSound : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;
   
    void Start()
    {
        if(!PlayerPrefs.HasKey("soundVolume"))
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
        
    }

    public void ChangeVolume()
    {
       AudioListener.volume = VolumeSlider.value;
       Save(); 
    }

    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("soundVolume");
    }



    private void Save()
    {
        PlayerPrefs.SetFloat("soundVolume", VolumeSlider.value);
    }

}
