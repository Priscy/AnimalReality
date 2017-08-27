using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Out : MonoBehaviour {
	public UIButton outBtn;
	public string  OutScene;
	// Use this for initialization
	void Start () {
		outBtn.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnEnable () {
		EventDelegate.Add (outBtn.onClick, outClicked);
	}
	void outClicked () {
		SceneManager.LoadScene(OutScene, LoadSceneMode.Additive);
	}
}
