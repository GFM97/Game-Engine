using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelAccess : MonoBehaviour {

	public int level;
	public GameObject image;

	void Awake()
	{
		bool active = PlayerPrefs.GetInt ("level") <= level;
		image.SetActive (active);

		GetComponent<Button> ().interactable = active;
	}

}