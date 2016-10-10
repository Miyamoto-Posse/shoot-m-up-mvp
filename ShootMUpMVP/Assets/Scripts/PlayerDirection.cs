using UnityEngine;
using System.Collections;

public class PlayerDirection : MonoBehaviour {

	void Update () {
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		Vector3 dir = Input.mousePosition - pos;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
		
		// transform.Rotate((Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime), 
		// 				 (Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime),
		// 				 (Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime),
		// 				  Space.World);
	
		// Vector3 mousePosition = Input.mousePosition;
		// float mouseX = mousePosition.x;
		// float mouseY = mousePosition.y;
		// Debug.Log(transform.localRotation);
	}
}
