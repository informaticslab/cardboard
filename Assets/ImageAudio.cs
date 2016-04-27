using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImageAudio : MonoBehaviour {
	
	public GameObject image;
	public GameObject play;
	private AudioSource audio;

	void Start(){
		audio = image.GetComponent<AudioSource> ();
	}

	public void playAudio(){
		if (audio.isPlaying) {
			audio.Pause ();
		} else {
			audio.Play ();
		}
	}
}
