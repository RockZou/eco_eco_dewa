﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class UIButtonFuncs : MonoBehaviour {
	private GameObject ChallengesUI;

	public AudioSource open_page;

	// Use this for initialization
	void Start () {
		open_page = GameObject.Find ("Open_page").GetComponent<AudioSource>();
		Debug.Log ("UIButtofnFuncs Start Called");
	}
	
	public void openWindow(GameObject theWindow){
		open_page.Play();
		Debug.Log ("UIButtonFuncs openWindow is called opening "+theWindow.name+" window");
		theWindow.SetActive (true);
	}

	public void closeWindow(GameObject theWindow){
		open_page.Play();
		Debug.Log ("UIButtonFuncs closeWindow is called closing "+theWindow.name+" window");
		theWindow.SetActive (false);
	}

	public void toggleWindow(GameObject theWindow){
		open_page.Play();
		Debug.Log ("UIButtonFuncs toggleWindow is called toggling "+theWindow.name+" window");
		theWindow.SetActive (!theWindow.activeInHierarchy);
	}
	
	public void changeCoconut(int coconutChange){
		open_page.Play();
		Text coconutText = GameObject.Find ("coconuttext").GetComponent<Text>();
		int coconutAmount = int.Parse (coconutText.text) + coconutChange;
		coconutText.text = ""+coconutAmount;
	}

}
