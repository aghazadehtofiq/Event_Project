using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Toggle toggle;
    private bool isOn = true;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        soundOnImage = toggle.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleClicked()
    {
        if(isOn)
        {
            toggle.image.sprite = soundOffImage;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            toggle.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
