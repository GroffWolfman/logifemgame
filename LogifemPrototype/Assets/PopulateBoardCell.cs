using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateBoardCell : MonoBehaviour {

public ArrayList itemsOnBoard = new ArrayList();
public Object[] usableCells;
public Object keyCell;
public Object PlannerCell;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//this adds the item textures to the board
	void addToBoard(Texture addingItem){
		itemsOnBoard.Add(addingItem);

	}

	//take our items on the board and scatter them about
	void repopulateBoard(){
		for (int i = 0; i < itemsOnBoard.Count; i++){
			int randomCell = Mathf.Round(random(usableCells.Length));
			usableCells[randomCell].Texture = itemsOnBoard.get(i).Texture;
		}
	}

}
