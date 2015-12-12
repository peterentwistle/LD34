using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour {

	void OnMouseOver() {
		Debug.Log("Hit object: " + this.name);
	}
}
