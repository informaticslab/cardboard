using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuItemController : MonoBehaviour {
	public Image image;
	public Text label;

	private ArrayList menuItems = new ArrayList{ "Cat Pic", "Cat Video", "Cat Object", "Virtual Tour" };
	private string[] labels = { "Pic", "Vid", "3D Heart", "Tour" };
	private string[] scenes = { "_scenes/CatPicture", "_scenes/CatVideo", "_scenes/CatObject", "_scenes/Office360" };

	/*
	private ArrayList menuItems = new ArrayList{ "Cat Pic", "Cat Video", "Cat Object", "Virtual Tour" };
	private string[] labels = { "Pic", "Vid", "3d Heart", "Tour" };
	private string[] scenes = { "_scenes/CatPicture", "_scenes/CatVideo", "_scenes/CatObject", "_scenes/Office360" };
	*/
	private int which;

	//public Text text;
	Vector3 imageScaler = new Vector3 (.25F, .25F);

	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		//label = GetComponent<Text> ();
		label.text = "";

		which = menuItems.IndexOf (image.tag);
	}

	public void selectItem (){
		
		image.color = Color.yellow;
		image.transform.localScale += imageScaler;
		label.text = labels [which];
	}
	public void deselectItem (){
		image.color = Color.white;
		image.transform.localScale -= imageScaler;
		label.text = "";

	}
	public void clickItem (){
		Debug.Log ("clicked item " +image.tag);


			SceneOrientation.offset = VRInput.Instance.Yaw;
			StartCoroutine(ChangeScene(scenes[which]));
			//SceneManager.LoadScene (scenes [which], LoadSceneMode.Single);

	}
	IEnumerator ChangeScene(string scene){
		//yield return new WaitForSeconds (0.6f);
		float fadeTime = GameObject.Find ("OrientationRoot").GetComponent<Fading> ().BeginFade (1);
		yield return new WaitForSeconds (0.5f);
		SceneManager.LoadScene (scene, LoadSceneMode.Single);	
	}
}
