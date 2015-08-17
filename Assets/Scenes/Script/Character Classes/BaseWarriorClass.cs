using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public void WarriorClass(){
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong and powerful hero.";
		Stamina = 15;
		Endurance = 11;
		Strength = 17;
		Intellect = 10; 
	}
	

}
