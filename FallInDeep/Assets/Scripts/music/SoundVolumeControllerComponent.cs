using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SoundVolumeControllerComponent : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] TextMeshProUGUI text;
    private AudioSource music;
    private void Awake()
    {
        music = GameObject.FindWithTag("MUSIC").GetComponent<AudioSource>();
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
        music.volume = volumeSlider.value;
        text.text = Mathf.Round((float)volumeSlider.value * 100) + "%";
        Save();
    }
    private void Load(){
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        music.volume = volumeSlider.value;
        text.text = Mathf.Round((float)volumeSlider.value * 100) + "%";
    }
    private void Save(){
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
