using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinStateChecker : MonoBehaviour
{
	[SerializeField] private GameObject canvas;

	public AudioSource audioSource1;
	public AudioSource audioSource2;

	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			canvas.SetActive(true);
			audioSource1.Stop();
			audioSource2.Play();
			yield return new WaitForSeconds(3);
			//SceneManager.LoadScene(scenename);
		}
	}
}
