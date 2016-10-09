using UnityEngine;
using System.Collections;

public class PlayerDirection : MonoBehaviour {

	void Start () {

	}

	void Update () {
		Vector3 mousePosition = Input.mousePosition;
		float mouseX = mousePosition.x;
		float mouseY = mousePosition.y;
		Debug.Log(transform.localRotation);
	}
}
