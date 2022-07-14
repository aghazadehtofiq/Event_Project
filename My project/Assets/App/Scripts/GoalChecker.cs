using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour
{
	[SerializeField] private GameObject canvas;
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			canvas.SetActive(true);
		}
	}
}
