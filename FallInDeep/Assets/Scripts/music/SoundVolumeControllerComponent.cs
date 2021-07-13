using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SoundVolumeControllerComponent : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AudioSource audiobg;
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI text; // текст, в который выводим значение громкости

    [Header("Keys")]
    [SerializeField] private string saveVolumeKey; // сохранение данных в реестр

    [Header("Tags")]
    [SerializeField] private string sliderTag; // поиск слайдера
    [SerializeField] private string textVolumeTag; // поиск текста

    [Header("Parameters")]
    [SerializeField] private float volume; // значение громкости от 0 до 1

    private void Awake()
    {
        if (PlayerPrefs.HasKey(this.saveVolumeKey))
        {
            this.volume = PlayerPrefs.GetFloat(this.saveVolumeKey);
            this.audiobg.volume = this.volume;

            GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
            if (sliderObj != null)
            {
                this.slider = sliderObj.GetComponent<Slider>();
                this.slider.value = this.volume;
            }
        }
        else
        {
            this.volume = 0.5f;
            PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);
            this.audiobg.volume = this.volume;
        }
    }
    private void LateUpdate()
    {
        GameObject sliderObj = GameObject.FindWithTag(this.sliderTag);
        if (sliderObj != null)
        {
            this.slider = sliderObj.GetComponent<Slider>();
            this.volume = slider.value;

            if (this.audiobg.volume != this.volume)
            {
                PlayerPrefs.SetFloat(this.saveVolumeKey, this.volume);

            }

            GameObject textObj = GameObject.FindWithTag(this.textVolumeTag);
            if (textObj != null)
            {
                this.text = textObj.GetComponent<TextMeshProUGUI>();

                this.text.text = Mathf.Round((float)this.volume * 100) + "%";
            }
        }

        this.audiobg.volume = this.volume;
    }

}
