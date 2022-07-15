using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour
{
	[SerializeField] private GameObject canvas;
	IEnumerator OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			canvas.SetActive(true);
			yield return new WaitForSeconds(3);
			canvas.SetActive(false);
		}
	}
}
