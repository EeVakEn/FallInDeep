using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SoundVolumeControllerComponent : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] TextMeshProUGUI text;
    private void Awake()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume",0.5f);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolume(){
        AudioListener.volume = volumeSlider.value;
        text.text = Mathf.Round((float)volumeSlider.value * 100) + "%";
        Save();
    }
    private void Load(){
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        text.text = Mathf.Round((float)volumeSlider.value * 100) + "%";
    }
    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
