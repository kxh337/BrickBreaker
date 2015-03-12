using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	//all Main menu options
	public GameObject startGame, highScores, credits, endGame;
	public TouchInput input;

	// Use this for initialization
	void Start () {
	
	}
	//loads scene by name
	void loadScene(string scene){
		Application.LoadLevel(scene);
	}
	
	//ends the game
	void exitGame(){
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
		//tap on screen
		if(input.getTouchCount() != 0){
			if(input.getHitObject().Equals(startGame)){
				loadScene("GameScene");
			}
			else if(input.getHitObject().Equals(highScores)){
				loadScene("HighScores");
			}
			else if(input.getHitObject().Equals(credits)){
				loadScene("Credits");
			}
			else if(input.getHitObject().Equals(endGame)){
				exitGame();
			}
		}
	}


}
