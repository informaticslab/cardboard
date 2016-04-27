using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {
	public Text intro;
	public Text text1;
	public Text text2;
	public Button next;

	public void onClick (){
		if (intro.gameObject.activeInHierarchy) {
			intro.gameObject.SetActive (false);
			text1.gameObject.SetActive (true);
		} else if (text1.gameObject.activeInHierarchy) {
			text1.gameObject.SetActive (false);
			text2.gameObject.SetActive (true);
			next.gameObject.SetActive (false);
		}
	}
}
