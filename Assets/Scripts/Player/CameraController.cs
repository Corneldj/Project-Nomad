using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Public Variables
	public GameObject targetPosition;
	public GameObject player;

	// Private Variables


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Assign Camera Position
		transform.position = targetPosition.transform.position;

		//Quaternion.Lerp(player.transform.rotation, new Quaternion(0.0f,transform.rotation.y,0.0f,transform.rotation.w),0.0f);
		// Assign new rotation to player
		player.transform.rotation = new Quaternion(0.0f,transform.rotation.y,0.0f,transform.rotation.w);
	}
}