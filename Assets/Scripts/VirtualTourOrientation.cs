using UnityEngine;
using System.Collections;

public class VirtualTourOrientation : MonoBehaviour {
	private Skybox sky;
	// Use this for initialization
	void Start () {
		RenderSettings.skybox.SetFloat ("_Rotation", 360 - (SceneOrientation.offset + VRInput.Instance.Yaw));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
