using UnityEngine;
using System.Collections;

public class BounceBar : MonoBehaviour {
	public static bool started;
	public float speed;
	public GameObject ball;
	public Vector3 offset;
	public Vector3 force;
	public float minBar;
	public float maxBar;
	// Use this for initialization
	void Start () {
		started = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime,Camera.main.transform);
		if(transform.position.x <= minBar){
			transform.position = new Vector3 (minBar, -8,0);
		}
		if(transform.position.x>=maxBar){
			transform.position = new Vector3 (maxBar, -8,0);
		}
		if(started == false){
			if(!ball.activeSelf){
				ball.SetActive(true);
			}
				ball.transform.position = transform.position + offset;
				ball.rigidbody.velocity = Vector3.zero;
			if(Input.GetMouseButtonDown(0)&&ball){
				ball.rigidbody.AddForce(force);
				started = true;
			}
		}
	
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag.Equals("Ball")){
//			float x = other.gameObject.rigidbody.velocity.x;
//			float y = other.gameObject.rigidbody.velocity.y;
			float mag = BallScript.ballSpeed;
			float diff = other.transform.position.x - this.transform.position.x;
			if (diff >= 1)
				diff = .99f;
			else if (diff <= -1)
				diff = -.99f;
			int sign;
			if (diff > 0)
				sign = 1;
			else
				sign = -1;
			float x = mag * diff;
			float y = mag * Mathf.Sin(Mathf.Acos(diff * sign));
			other.gameObject.GetComponent<BallScript>().setVelNums(x, y);
		}
	}
}
