using UnityEngine;
using System.Collections;

public class TetrisInsertion : MonoBehaviour {
	public static int level;
	public static int score;
	//the different blocks you can get in tetris
	public GameObject[] blocks;
	public int levelUpScore;

	private float insertRate;
	private float insertTime;

	// Use this for initialization
	void Start () {
		level = 0;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= insertTime){
			//insertblock
			insertTime += insertRate;
		}
		checkLevel();
	}

	void checkLevel(){
		if(score >= levelUpScore){
			level++;
			//need some sort of balanced equation here
			levelUpScore = levelUpScore + level;
		}
	}
}
