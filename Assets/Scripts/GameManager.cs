using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int broken = 0;
	//public int number = 2;
	public int step = 1;
	public int nextFall;
	public GameObject brick;

	// Use this for initialization
	void Start () {
		nextFall = step;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void spawn() {
		for (int x = -6; x <=6; x = x + 2){
			//if (x%number == 0)
				Instantiate(brick, new Vector3(x, 13, 0), Quaternion.identity);
		}
	}
}
