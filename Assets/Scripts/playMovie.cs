using UnityEngine;
using System.Collections;

public class playMovie : MonoBehaviour {

	void start (){
		Handheld.PlayFullScreenMovie ("streamingassets/VID_20160407_102609.mp4", Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
	}
}
