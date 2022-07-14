using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject canvasOpening;
    [SerializeField] private GameObject canvasOptions;
    [SerializeField] private GameObject canvasGamePlay;
    [SerializeField] private GameObject canvasPause;

    public void Play()
    {
        canvasOpening.SetActive(false);
        canvasGamePlay.SetActive(true);
    }

    public void Options()
    {
        canvasOpening.SetActive(false);
        canvasOptions.SetActive(true);
    }

    public void Back()
    {
        canvasOptions.SetActive(false);
        canvasOpening.SetActive(true);
    }

    public void OptionsGamePlay()
    {
        canvasGamePlay.SetActive(false);
        canvasPause.SetActive(true);
    }

    public void Resume()
    {
        canvasPause.SetActive(false);
        canvasGamePlay.SetActive(true);
    }
    /*public void Mute()
    {
        
    }*/

    /*public void Quit()
    {
        Application.Quit
    }*/
}