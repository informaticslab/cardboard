using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CardboardBack : MonoBehaviour {
	void Awake() 
	{
		GetComponent<Cardboard>().OnBackButton += HandleOnBackButton;
	
	}

	public void HandleOnBackButton ()
	{
		Application.Quit ();
	}
}

