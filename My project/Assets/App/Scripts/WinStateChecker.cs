using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinStateChecker : MonoBehaviour
{
	[SerializeField] private GameObject canvas;
	[SerializeField] private TextMeshProUGUI levelText;

	int currentLevel = 1;
	public AudioSource audioSource1;
	public AudioSource audioSource2;

	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			canvas.SetActive(true);
			LoadText();
			audioSource1.Stop();
			audioSource2.Play();
			yield return new WaitForSeconds(3);
			SceneManager.LoadScene("Level 2");
		}
	}

	public void LoadText()
	{
		levelText.text = "Level " + currentLevel;
	}
}
