using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour {
	public GameObject button;
	Color initial;

	float currentYaw = 0;
	public float maxYaw = 15;
	float previousYaw;

	public bool lockPitch = false;
	public float pitch = 0;

	public bool counterRotateUI = false;
	public Transform UI;


	public float Pitch{
		get{
			return pitch;
		}
		set{
			pitch = value;
		}
	}

	// Use this for initialization
	void Start () {
		previousYaw = VRInput.Instance.Yaw;
		initial = button.GetComponent<Image> ().color;
	}
	void Update(){
		if (VRInput.Instance.Pitch < -22) {
			button.GetComponent<Image> ().color = Color.white;
		} else {
			button.GetComponent<Image> ().color = initial;
		}
	}

	void LateUpdate () {
		float deviceYaw = VRInput.Instance.Yaw;
		float devicePitch = VRInput.Instance.Pitch;

		float deltaYaw = Mathf.DeltaAngle(deviceYaw, previousYaw);

		float targetYaw = currentYaw + deltaYaw;

		currentYaw = Mathf.Clamp(targetYaw, -maxYaw,maxYaw);

		UI.transform.position = VRInput.Instance.Position;


		previousYaw = deviceYaw;
		Quaternion menuPitch = Quaternion.AngleAxis(pitch, Vector3.right);
		Quaternion deviceRotation = Quaternion.AngleAxis(deviceYaw, Vector3.up);
		Quaternion devicePitchRotation = Quaternion.AngleAxis(-devicePitch, Vector3.right);


		if(!lockPitch){
			UI.transform.localRotation = deviceRotation *Quaternion.AngleAxis( currentYaw, Vector3.up)*menuPitch;
		}
		else{
			UI.transform.localRotation = deviceRotation * Quaternion.AngleAxis( currentYaw, Vector3.up)*devicePitchRotation *menuPitch;
		}

		if(counterRotateUI){
			UI.localRotation = Quaternion.AngleAxis(-pitch, Vector3.right);
		}
	}
	public void onClick (){
		if (button.tag.Equals("Exit")) {
			Application.Quit ();
		} else if (button.tag.Equals("Back")) {
			SceneOrientation.offset = VRInput.Instance.Yaw;
			goHome ();
		}
	}

	public static void goHome(){
		SceneManager.LoadScene ("_scenes/Main", LoadSceneMode.Single);

	}

	public void hovered (){
		button.GetComponentInChildren<Text> ().color = Color.white;
		button.gameObject.transform.localScale += new Vector3(0.05F, 0.05F, 0);
	}

	public void unhovered (){
		button.GetComponentInChildren<Text> ().color = initial;
		button.gameObject.transform.localScale -= new Vector3 (0.05F, 0.05F, 0);
	}
}
