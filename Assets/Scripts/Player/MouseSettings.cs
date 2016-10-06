using UnityEngine;
using System.Collections;

public class MouseSettings : MonoBehaviour {

	public bool lockMouse;
	public bool hideMouse;

	// Use this for initialization
	void Start () {
		lockMouse = false;
		hideMouse = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (lockMouse)
			Cursor.lockState = CursorLockMode.Locked;
		else
			Cursor.lockState = CursorLockMode.None;

			Cursor.visible = hideMouse;
			
	}

	void MouseOptions () {

	}
		
}
