using UnityEngine;
using System.Collections;

//class that only looks at input of one finger which will always be the first finger on the screen
public class TouchInput : MonoBehaviour {
	private Vector3 touchPosition;
	private int touchCount;
	private TouchPhase phase;
	private RaycastHit hit;

	public GameObject getHitObject(){
		return hit.collider.gameObject;
	}

	public int getTouchCount(){
		return this.touchCount;
	}

	public TouchPhase getPhase(){
		return this.phase;
	}

	public Vector3 getTouchTrans(){
		return this.touchPosition;
	}
	// Use this for initialization
	void Start () {
		touchCount = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//get input
		if(Input.touchCount > 0){
			touchCount = Input.touchCount;
			touchPosition = Input.GetTouch(0).position;
			phase = Input.GetTouch(0).phase;
			RaycastHit hit;
			if(Physics.Raycast(touchPosition, Camera.main.transform.forward, out hit)){
				this.hit = hit;
			}
		}
		else{
			touchCount = 0;
		}
	}
}
