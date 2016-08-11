using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
		if (target == null) {
			target = GameObject.FindGameObjectWithTag ("Player").transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.position.x, target.position.y, -10);
	}
}
