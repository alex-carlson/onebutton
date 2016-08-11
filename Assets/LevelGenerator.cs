using UnityEngine;
using System.Collections;

public class LevelGenerator : MonoBehaviour {

	int level = 0;
	int size = 24;

	// density is the % chance to spawn a wall.  0-1.
	float density = 0.1f;

	public GameObject Wall;

	Vector2 offset;

	// Use this for initialization
	void Start () {

		offset = new Vector2 (size/2, size/2);

		LevelGen ();
	}

	void LevelGen(){
		for (int i = 0; i < size; i++) {
			for (int j = 0; j < size; j++) {

				float r =  Random.Range(0f, 1f);

				if (r < density) {
					Instantiate(Wall, new Vector3(i-offset.x, j-offset.y, -2), Quaternion.identity);
				}
			}
		}
	}

	void NextLevel(){
		level++;
		density = density * 1.1f;
		Debug.Log (density);
		LevelGen ();
	}
}
