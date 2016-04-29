using UnityEngine;
using System.Collections;

public class SceneOrientation : MonoBehaviour {
	public static float offset = 0;
	
	// Use this for initialization
	void Start () {
		OrientateScene(offset + VRInput.Instance.Yaw);
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void OrientateScene(float yaw){
		GameObject orientationRoot = GameObject.Find ("OrientationRoot");
		orientationRoot.transform.localRotation = Quaternion.AngleAxis(yaw, Vector3.up);
	}
}
