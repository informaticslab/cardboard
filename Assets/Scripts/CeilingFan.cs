using UnityEngine;
using System.Collections;

public class CeilingFan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (fan ());
	}

	IEnumerator fan (){
		while (true) {
			transform.Rotate (new Vector3 (0, 360, 0) * Time.deltaTime);
			yield return null;
		}
	}
}
