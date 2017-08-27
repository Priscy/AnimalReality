using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	
	public GameObject startScreen;
	public GameObject welcomeScreen;
	public UIButton startBtn;
	public UIInput name;
	public UIButton nextBtn;
	public UILabel welcomeLabel;
	public UILabel nameLabel;
	public UILabel infoLabel;
	public UIButton next2Btn;
	public UIButton tutorialButton;
	public string nameString;
	// Use this for initialization
	void Start () {
		startScreen.SetActive (true);
		welcomeScreen.SetActive (false);
		startBtn.gameObject.SetActive(true);
		name.gameObject.SetActive(false);
		nextBtn.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		

	}
	void OnEnable () {
		EventDelegate.Add (startBtn.onClick,iniciarClicked);
		EventDelegate.Add (nextBtn.onClick,continuarClicked);
		EventDelegate.Add (next2Btn.onClick,continuarVRClicked);
		EventDelegate.Add (tutorialButton.onClick,tutorialClicked);
	}
	void iniciarClicked () {
		startBtn.gameObject.SetActive(false);
		name.gameObject.SetActive(true);
		nextBtn.gameObject.SetActive(true);
		Debug.Log ("x");
	}
	void continuarClicked () {
		startScreen.SetActive (false);
		nameString=name.GetComponent<UIInput>( ).text;
		Debug.Log (nameString);
		name.gameObject.SetActive(false);
		Debug.Log ("x");
		welcomeScreen.SetActive (true);
		nameLabel.text = nameString;
	}
	void continuarVRClicked () {
		SceneManager.LoadScene("03.Main", LoadSceneMode.Additive);
		}	
	void tutorialClicked () {
		SceneManager.LoadScene("02.AyudaVisual", LoadSceneMode.Additive);
	}	
}
