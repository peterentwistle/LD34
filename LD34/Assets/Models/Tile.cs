using UnityEngine;
using System.Collections;

public class Tile {
	
	public int X { get; private set; }
	public int Y { get; private set; }
	public GameObject Object { get; set; } // Probably rename this later

	public Tile(int x, int y) {
		X = x;
		Y = y;
	}
}
