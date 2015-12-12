using UnityEngine;
using System.Collections;

public class WorldController : MonoBehaviour {

	private World world;
	public Sprite defaultTile;

	// Use this for initialization
	void Start() {
		world = new World(100, 100);

		for (int x = 0; x < world.Width; x++) {
			for (int y = 0; y < world.Height; y++) {
				Tile tileDate = world.GetTileAt(x, y);
					
				GameObject tileGameObj = new GameObject();
				tileGameObj.name = "Tile_X_"+x+"_Y_"+y;
				tileGameObj.transform.position = new Vector3(tileDate.X, tileDate.Y, 0);

				SpriteRenderer tileSpriteRenderer = tileGameObj.AddComponent<SpriteRenderer>();

				tileSpriteRenderer.sprite = defaultTile;
			}
		}
	}
	
	// Update is called once per frame
	void Update() {
	
	}
}
