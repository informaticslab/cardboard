using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour {
	public Text text1;
	public Text text2;
	public Button next;

	public void onClick (){
			text1.gameObject.SetActive (false);
			text2.gameObject.SetActive (true);
			next.gameObject.SetActive (false);
	}
}
