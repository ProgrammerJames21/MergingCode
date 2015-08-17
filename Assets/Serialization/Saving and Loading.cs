using UnityEngine;
using System.Collections;

public class SavingAndLoading : MonoBehaviour {
	bool  saving = true;
	
	void  Start (){
		
		OnLoad();
		autoSaveEnable();
	}
	
	void  autoSaveEnable (){
		
		while(saving) {
			yield return new WaitForSeconds(5);
			Debug.Log("save me");
			OnSave();
		}
	}
	
	void  OnSave (){
		
		PlayerPrefs.SetInt("CurXp", playerHealth.curXp); 
	}
	
	void  OnLoad (){
		
		Debug.Log("loaded");
		playerHealth.curXp = PlayerPrefs.GetInt("CurXp");
	}
	
}