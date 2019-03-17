using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateBoardCell : MonoBehaviour {

public List<Texture> itemsOnBoard = new List<Texture>();
public GameObject[] usableCells;
public GameObject keyCell;
public GameObject PlannerCell;

//textures
public Texture holderTexture;
public Texture keyTexture;
public Texture plannerTexture;


	// Use this for initialization
	void Start () {
		for (int c = 0; c < usableCells.Length; c++){
		usableCells[c].GetComponent<MeshRenderer>().material.mainTexture = holderTexture;
		}
		keyCell.GetComponent<MeshRenderer>().material.mainTexture = keyTexture;
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

			//Material randomCellMat = usableCells[randomCell].GetComponent<Material>();
			//randomCellMat = itemsOnBoard[i];

			//THIS IS WHAT WE NEED VV BUT HOW TO MAKE IT WORK?
			//usableCells[randomCell].GetComponent<Material>.material.Texture = itemsOnBoard[i];
		}
	}

}
