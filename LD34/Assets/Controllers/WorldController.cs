using UnityEngine;
using System.Collections;
using System;

public class WorldController : MonoBehaviour {

	private World world;
	public GameObject GroundTile;
	public Sprite DefaultTile;

	// Use this for initialization
	void Start() {
		world = new World();

		for (int x = 0; x < world.Width; x++) {
			for (int y = 0; y < world.Height; y++) {
				Tile tileDate = world.GetTileAt(x, y);
					
				GameObject tileGameObj = Instantiate(GroundTile);
				tileGameObj.name = "Tile_X_"+x+"_Y_"+y;
				tileGameObj.transform.position = new Vector3(tileDate.X, tileDate.Y, 0);

				SpriteRenderer tileSpriteRenderer = tileGameObj.AddComponent<SpriteRenderer>();
				tileGameObj.AddComponent<BoxCollider2D>();

				tileSpriteRenderer.sprite = DefaultTile;
			}
		}
	}

	// Update is called once per frame
	void Update() {
		
	}
}
