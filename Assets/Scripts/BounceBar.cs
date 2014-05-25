﻿using UnityEngine;
using System.Collections;

public class BounceBar : MonoBehaviour {
	public static bool started;
	public float speed;
	public GameObject ballPrefab;
	public Vector3 offset;
	public Vector3 force;
	public float minBar;
	public float maxBar;
	public GameObject Lasers;
	public static int ballCount;
	private float laserStart;
	private float laserEnd;
	private bool ballInstantiated;
	private GameObject ball;
	// Use this for initialization
	void Start () {
		started = false;
		Lasers.SetActive(false);
		ballInstantiated = false;
		ballCount =0;
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

		if( ballCount ==0){
			if(!ballInstantiated){
				ball = (GameObject)Instantiate(ballPrefab,transform.position +offset,transform.rotation);
				ballInstantiated = true;
			}
				ball.transform.position = transform.position + offset;
				ball.rigidbody.velocity = Vector3.zero;
			if(Input.GetMouseButtonDown(0)){
				ball.rigidbody.AddForce(force);

				ballInstantiated = false;
				ballCount++;
			}
		}
		if(Time.time > laserEnd){
			Lasers.SetActive(false);
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

	public void LaserOn(float time){
		laserStart = Time.time;
		laserEnd = Time.time + time;
		Lasers.SetActive(true);
	}
}
