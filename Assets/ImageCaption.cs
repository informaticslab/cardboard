using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageCaption : MonoBehaviour {
	
	public GameObject captionButton;
	public GameObject caption;

	public void onClick(){
		if (caption.gameObject.activeInHierarchy) {
			caption.gameObject.SetActive (false);
		} else {
			caption.gameObject.SetActive (true);
		}
	}
}
