using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	private Vector3	dragStartPosition;
	public float dragSpeed;

	void Start() {
	}

	void Update() {
		/*
		if (Input.GetMouseButtonDown(0)) {
			dragStartPosition = Input.mousePosition;
			return;
		}

		if (!Input.GetMouseButton(0)) {
			return;
		}

		Vector3 position = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragStartPosition);
		Vector3 moveTo = new Vector3(position.x * dragSpeed, position.y * dragSpeed, 0);
		transform.Translate(moveTo, Space.World);
		*/
	}
}
