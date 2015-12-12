using UnityEngine;
using System;
using System.Collections;

public class World {

	private Tile[,] _tiles;
	public int Width { get; private set; }
	public int Height { get; private set; }

	public int Size {
		get {
			return Width * Height;
		}
	}

	public World(int width = 10, int height = 10) {
		Width = width;
		Height = height;
		initiateTiles();
	}

	private void initiateTiles() {
		_tiles = new Tile[Width, Height];

		int i = 0;
		for (int x = 0; x < Width; x++) {
			for (int y = 0; y < Height; y++) {
				_tiles[x, y] = new Tile(x, y);
				Debug.Log(String.Format("Tile x: {0}, y: {1}. Tile number: {2}", x, y, ++i));
			}

		}
	}

	public Tile GetTileAt(int x, int y) {
		return _tiles[x, y];
	}
}
