using UnityEngine;
using System.Collections;

public class HeartScene : MonoBehaviour {
	public GameObject intro;
	public GameObject heart;
	public GameObject lookDownMenu;
	public GameObject reticle;

	public void onClick(){
		intro.SetActive (false);
		heart.SetActive (true);
		lookDownMenu.SetActive (false);
		reticle.SetActive (false);
	}
}
