using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public float x;
	public float y;
	public static float ballSpeed = 15f;

	// Use this for initialization
	void Start () {
	
	}
	//sets new velocity value with newX vel component
	public void setVelNums(float newX) {
		x = newX;
		y = this.gameObject.rigidbody.velocity.y;
		setVel ();
	}
	//sets new velocity values with newX and newY vel components
	public void setVelNums(float newX, float newY) {
		x = newX;
		y = newY;
		setVel ();
	}

	//sets the velocity
	public void setVel() {
		this.gameObject.rigidbody.velocity = new Vector3(x, y, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
