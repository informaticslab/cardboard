using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraOrbit : MonoBehaviour {
	public float distance = 3;
	private CardboardHead head;

	void Start() {
		head = Camera.main.GetComponent<StereoController>().Head;
	}

	void Update () {
		transform.position = head.transform.position + (head.Gaze.direction * distance);
	}

	public void onClick (){
		SceneOrientation.offset = VRInput.Instance.Yaw;
		StartCoroutine("ChangeScene");
	}
	IEnumerator ChangeScene(){
		//yield return new WaitForSeconds (0.6f);
		float fadeTime = GameObject.Find ("OrientationRoot").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (0.5f);
		SceneManager.LoadScene ("_Scenes/Main", LoadSceneMode.Single);	
	}
}