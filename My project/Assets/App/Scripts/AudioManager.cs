using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] private List<AudioSource> musicSources;
    [SerializeField] private List<AudioSource> sfxSources;

    //private Slider musicSlider;
    //private Slider sfxSlider;

    float musicVolume;
    float sfxVolume;

    private void OnEnable()
    {
        if (instance != null && instance != this)
        {
            Destroy(instance.gameObject);
        }
        instance = this;
        DontDestroyOnLoad(this);

        SetupAudioSources();
        SetupAudioSourcesWithData();
        //SetAudioSliders();
    }

    private void SetupAudioSources()
    {
        sfxSources.Clear();
        musicSources.Clear();

        List<AudioSource> allAudioSources = GameObject.FindObjectsOfType<AudioSource>().ToList();

        foreach (AudioSource source in allAudioSources)
        {
            if (source.gameObject.CompareTag("MusicSource"))
            {
                musicSources.Add(source);
            }
            else if (source.gameObject.CompareTag("SoundSource"))
            {
                sfxSources.Add(source);
            }
        }
    }

    private void SetupAudioSourcesWithData()
    {
        if (PlayerPrefs.GetInt("FirstStarted") == 0)
        {
            PlayerPrefs.SetFloat("musicVolume", 1f);
            PlayerPrefs.SetFloat("sfxVolume", 1f);
            PlayerPrefs.SetInt("FirstStarted", 1);
        }

        musicVolume = PlayerPrefs.GetFloat("musicVolume");
        sfxVolume = PlayerPrefs.GetFloat("musicVolume");

        foreach (AudioSource musicSrc in musicSources)
        {
            musicSrc.volume = musicVolume;
        }
        foreach (AudioSource sfxSrc in sfxSources)
        {
            sfxSrc.volume = sfxVolume;
        }
    }

    /*private void SetAudioSliders()
    {
        //musicSlider = GameObject.FindGameObjectWithTag("MusicSource").GetComponent<Slider>();
        //sfxSlider = GameObject.FindGameObjectWithTag("SoundSource").GetComponent<Slider>();
        List<Slider> sliders = GameObject.FindObjectsOfType<Slider>().ToList();

        foreach (Slider slider in sliders)
        {
            if (slider.CompareTag("MusicSource"))
            {
                musicSlider = slider;
            }
            else if (slider.CompareTag("SoundSource"))
            {
                sfxSlider = slider;
            }
        }

        if (musicSlider != null)
        {
            musicSlider.value = musicVolume;
            musicSlider.onValueChanged.AddListener(OnMusicSliderChanged);
        }
        if (sfxSlider != null)
        {
            sfxSlider.value = sfxVolume;
            sfxSlider.onValueChanged.AddListener(OnSoundSliderChanged);
        }

        musicSlider.value = musicVolume;
        sfxSlider.value = sfxVolume;
    }

    private void OnMusicSliderChanged(float musicVol)
    {
        foreach (AudioSource musicSrc in musicSources)
        {
            musicSrc.volume = musicVol;
        }
        PlayerPrefs.SetFloat("musicVolume", musicVol);
    }
    private void OnSoundSliderChanged(float sfxVol)
    {
        foreach (AudioSource sfxSrc in sfxSources)
        {
            sfxSrc.volume = sfxVol;
        }
        PlayerPrefs.SetFloat("sfxVolume", sfxVol);
    }*/
}