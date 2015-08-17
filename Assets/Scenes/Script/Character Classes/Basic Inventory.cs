using UnityEngine;
using System.Collections;

public class BasicInventory : MonoBehaviour 
	{
	public int SlotName { get; set; }
	public BasicInventory ItemInSlot { get; set; } // Where InventoryItem is a class that is an inventory item
	
	GameObject inventoryText;

	enum SlotNames
	{
		Shovel,
		Medicine
	}

	GameObject[] slots = new GameObject[(int)SlotNames.SlotCount];

	GameObject thingOnShovel = slots[(int)SlotNames.Shovel];
	GameObject thingOnMedicine = slots [(int)SlotNames.Medicine];

		

}
