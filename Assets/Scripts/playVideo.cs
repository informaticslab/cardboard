using UnityEngine;
using System.Collections;

public class playVideo : MonoBehaviour {
	public MediaPlayerCtrl mpc;

	public bool m_bFinish = false;

	// Use this for initialization
	void Start () {
		

		mpc.Load ("CDC-TV.mp4");
		mpc.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnd()
	{
		m_bFinish = true;
	}
}
