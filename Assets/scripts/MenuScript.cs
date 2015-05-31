using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	public void clickSingleGame(){

		//Application.loadedLevel("GameScene");
	}

	public void clickNetGame(){

		print (Application.loadedLevelName);
		Application.LoadLevel("GameScene");
	}
}
