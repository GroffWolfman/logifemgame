using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateBoardCell : MonoBehaviour {

public List<Texture> itemsOnBoard = new List<Texture>();
public GameObject[] usableCells;
public GameObject keyCell;
public GameObject PlannerCell;

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
			int randomCell = Random.Range(0,usableCells.Length);
			//THIS IS WHAT WE NEED VV BUT HOW TO MAKE IT WORK?
			//usableCells[randomCell].material.Texture = itemsOnBoard[i].Texture;
			usableCells[randomCell].MeshRenderer;
		}
	}

}
