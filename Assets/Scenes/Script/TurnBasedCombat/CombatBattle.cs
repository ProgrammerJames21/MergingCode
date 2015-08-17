using UnityEngine;
using System.Collections;

public class CombatBattle : MonoBehaviour {
	int turn = 1;
	int phase = 0;
	string enemyToAttack;
	
	//player stats
	float playerCurHp = 100.0f;
	float playerMaxHp = 100.0f;
	float playerMinAttack = 5.0f;
	float playerMaxAttack = 10.0f;
	
	bool  enemyTurnActivated = false;
	
	void  OnGUI (){
		
		MainGame1 otherScript = gameObject.Find("MainGame").GetComponent<MainGame1>();
		if(otherScript.inBattle == true) {
			// If it's the players turn then show combat buttons
			if(turn == 1) {
				
				//select attack
				if(phase == 0) {
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 + 200,140,20), "Attack")) {
						phase = 1;
					}
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 +225,140,20), "Item")) {
						phase = 2;
					}
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 + 250,140,20), "Run")) {
						phase = 3;
					}
				}
				
				//attack selection
				if(phase == 1) {
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 + 200,140,20), "Slice")) {
						turn = 2;
						phase = 0;
					}
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 +225,140,20), "Back")) {
						phase = 0;
					}
				}
				
				if(phase == 2) {
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 + 200,140,20), "Health Potion")) {
						turn = 2;
						phase = 0;
					}
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 +225,140,20), "Back")) {
						phase = 0;
					}
				}
				
				if(phase == 3) {
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 + 200,140,20), "Run Away")) {
						phase = 0;
						otherScript.inBattle = false;
					}
					
					if (GUI.Button ( new Rect(Screen.width / 2 - 600,Screen.height / 2 +225,140,20), "Back")) {
						phase = 0;
					}
				}
			}
		}
	}
	
	
	
	void  Update (){
		
		//enemies turn
		if(turn == 2 && enemyTurnActivated == false) {
			enemyTurnActivated = true;
			enemyTurn();
		}
	}
	
	
	//After the player attacks then it's the enemy attack phase
	void  enemyTurn (){
		
		Debug.Log("enemy 1 turn began");
		Debug.Log("enemy 1 attacked");
		enemyTurnActivated = false;    
		turn = 1;
	}
}