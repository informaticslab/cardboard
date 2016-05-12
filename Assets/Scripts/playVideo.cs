using UnityEngine;
using System.Collections;

public class playVideo : MonoBehaviour {
	public MediaPlayerCtrl mpc;
	private GameObject playIcon;
	private GameObject pauseIcon;

	public bool m_bFinish = false;

	// Use this for initialization
	void Start () {
		pauseIcon = GameObject.Find ("PauseIcon");
		playIcon = GameObject.Find ("PlayIcon");

		mpc.Load ("CDC-TV.mp4");
		mpc.Play ();
	}

	void OnEnd()
	{
		m_bFinish = true;
	}

	public void toggleVideo(){
		if (mpc.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.PLAYING) {
			mpc.Pause ();
			pauseIcon.GetComponent<Animator> ().SetBool("isPaused", true);
			playIcon.GetComponent<Animator> ().ResetTrigger ("toggle");
		} else if (mpc.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.PAUSED) {
			mpc.Play ();
			pauseIcon.GetComponent<Animator> ().SetBool("isPaused", false);
			playIcon.GetComponent<Animator> ().SetTrigger ("toggle");

		}
	}
}
