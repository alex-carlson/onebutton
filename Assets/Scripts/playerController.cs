using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	ParticleSystem psys;

	public float turnTimer = 2;
	public float moveSpeed = 1;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("changeDir", 0, turnTimer);
		psys = GetComponent<ParticleSystem> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			GetComponent<SpriteRenderer> ().color = Color.blue;
			psys.startSize = 1;
		} else {
			GetComponent<SpriteRenderer> ().color = Color.yellow;
			psys.startSize = 0;
		}
	}

	void FixedUpdate(){
		transform.Translate (transform.up * moveSpeed * Time.deltaTime);
	}

	void changeDir(){
		transform.Rotate (new Vector3 (0, 0, Mathf.Round(Random.Range(1, 3)) * 45));
	}
}
