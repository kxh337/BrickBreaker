using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	
	public Material[] bricks;

	public int strength;

	// Use this for initialization
	void Start () {
		strength = (Random.Range(0, bricks.Length));
		gameObject.renderer.material = bricks [strength];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	 
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Ball"){
			if (strength <= 0)
				Destroy(gameObject);
			else {
				strength--;
				gameObject.renderer.material = bricks [strength];
			}
		}
	}
	
}
