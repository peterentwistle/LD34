using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

	public Sprite Spr;

	void OnMouseOver() {
		Debug.Log("Hit object: " + this.name);
	}

	void OnMouseUp() {
		// Test
		GameObject go = new GameObject("Conveyor");
		SpriteRenderer sr = go.AddComponent<SpriteRenderer>();
		sr.sprite = Spr;
		sr.sortingOrder = (int) ((World.Height - this.transform.position.y) + (this.transform.position.x));

		go.transform.position = new Vector3(this.transform.position.x + 0.5f, this.transform.position.y - 0.5f);
	}
}
