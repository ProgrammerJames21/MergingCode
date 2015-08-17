﻿using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	private BaseCharacterClass class1 = new BaseMageClass ();
	private BaseCharacterClass class2 = new BaseWarriorClass ();

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnPreviewGUI(){
		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class1.Intellect.ToString ());   // number values, not strings
		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);
		GUILayout.Label (class2.Strength.ToString ());
}

}