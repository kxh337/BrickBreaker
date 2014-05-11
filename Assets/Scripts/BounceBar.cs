using UnityEngine;
using System.Collections;

public class BounceBar : MonoBehaviour {
	public static bool started;
	public float speed;
	public GameObject ball;
	public Vector3 offset;
	public Vector3 force;
	// Use this for initialization
	void Start () {
		started = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime,Camera.main.transform);
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
}
