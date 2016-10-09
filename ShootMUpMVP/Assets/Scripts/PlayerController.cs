using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	Vector2 pos;
	public float speed;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		bool WKey = Input.GetKey(KeyCode.W);
		bool AKey = Input.GetKey(KeyCode.A);
		bool SKey = Input.GetKey(KeyCode.S);
		bool DKey = Input.GetKey(KeyCode.D);
		updatePosition(WKey, AKey, SKey, DKey);
		gameObject.transform.position = pos;
	}

	void updatePosition (bool WKey, bool AKey, bool SKey, bool DKey) {
		if (WKey) {
			pos.y += (0.1f * speed);
		}
		if (AKey) {
			pos.x -= (0.1f * speed);
		}
		if (SKey) {
			pos.y -= (0.1f * speed);
		}
		if (DKey) {
			pos.x += (0.1f * speed);
		}
	}
}
