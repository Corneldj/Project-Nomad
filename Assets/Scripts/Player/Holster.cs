using UnityEngine;
using System.Collections;

public class Holster : MonoBehaviour {

	//Public Variables
	public GameObject gun;

	// Use this for initialization
	void Start () {
		if (gun != null)
			equip (gun);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void equip(GameObject obj) {
		gun = obj;

		transform.parent = GameObject.Find ("Bip01_R_Hand").transform;
		transform.localPosition = new Vector3 (0,0,0);
		transform.localRotation = Quaternion.identity;
	}
}
