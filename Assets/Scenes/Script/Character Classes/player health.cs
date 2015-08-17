using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
		int curHealth = 100;
		int maxHealth = 100;
		GUIText healthtext;
		
		void  Start (){
			healthRegen();
		}
		
		void  Update (){
			
			healthtext.text = curHealth + " / " + maxHealth;
			
			if(curHealth < 0 ) {
				curHealth = 0;
			}
			
			if(curHealth > 100) {
				curHealth = 100;
			}
			
			if(Input.GetKeyDown("e")) {
				curHealth -= 10;
			}
		}
		
		void  healthRegen (){
			
			while(regenActive) {
				yield return new WaitForSeconds(0.5f);
				
				if(curHealth < maxHealth) {
					curHealth++;
				}
			}
		}
	}
	
