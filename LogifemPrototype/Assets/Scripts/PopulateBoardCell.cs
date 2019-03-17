using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateBoardCell : MonoBehaviour {

public List<Texture> itemsOnBoard = new List<Texture>();
public GameObject[] usableCells;
public GameObject KeyCell;
public GameObject PlannerCell;

//textures
public Texture holderTexture;
public Texture keyTexture;
public Texture plannerTexture;


	// Use this for initialization
	void Start () {
		wipeBoard();
		KeyCell.GetComponent<MeshRenderer>().material.mainTexture = keyTexture;
		KeyCell.GetComponent<CellScript>().cellAttribute = "keyTexture";
		PlannerCell.GetComponent<MeshRenderer>().material.mainTexture = plannerTexture;
		PlannerCell.GetComponent<CellScript>().cellAttribute = "plannerTexture";
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

			usableCells[randomCell].GetComponent<Material>().mainTexture = itemsOnBoard[i];

		}
	}

	//Wiping the Board visually so we can start fresh
	void wipeBoard(){
		//go through the cells that aren't Key or Planner and put the holder texture there
		for (int c = 0; c < usableCells.Length; c++){
		usableCells[c].GetComponent<MeshRenderer>().material.mainTexture = holderTexture;
		}

	}

}
