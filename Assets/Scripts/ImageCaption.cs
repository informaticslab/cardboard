using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageCaption : MonoBehaviour {
	
	public GameObject captionButton;
	public GameObject caption;
	private Animator anim;

	void Start(){
		anim = caption.GetComponent<Animator> ();
	}

	public void onClick(){
		if (anim.enabled == false) {
			anim.enabled = true;
		} else {
			if (anim.GetBool ("isHidden") == true) {
				anim.SetBool ("isHidden", false);
			} else {
				anim.SetBool ("isHidden", true);
			}
		}
	}
}
