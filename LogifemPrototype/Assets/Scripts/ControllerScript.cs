using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScript : MonoBehaviour
{

//Objects
public GameObject ourBoard;
public GameObject panel;
public GameObject mCanvas;

//Tracking
public List<GameObject> trackables = new List<GameObject>();
public List<GameObject> activeCards = new List<GameObject>();
public GameObject cardPrefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0)) {
            //send out a ray to try and hit the cells
            RaycastHit  hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //this is funky but basically we're seeing what we hit and interpretting the script and then in that interpretation, setting the is clicked variable to true                    
            if (Physics.Raycast(ray, out hit)) {
                CellScript cell = hit.collider.gameObject.GetComponent("CellScript") as CellScript;
                cell.isClicked = true;
            }         
        } 


        
    }


    void ActiveCellManager(){
    PopulateBoardCell board = ourBoard.GetComponent("PopulateBoardCell") as PopulateBoardCell;

    for (int b = 0; b < board.usableCells.Length; b++){
            if (board.usableCells[b].GetComponent<CellScript>().isActive){
                panel.GetComponent<MeshRenderer>().enabled = true;
            }

        }
    }

    //Creating a option selector, where you establish the topic followed by the options or array of options
    void cardSelect(){

        for (int t = 0; t < trackables.Count; t++){
            int cardCount = trackables[t].GetComponent<Tracking>().trackableItems.Count;
            for (int tc = 0; tc < trackables[t].GetComponent<Tracking>().trackableItems.Count; tc++){
            GameObject newCard = Instantiate(cardPrefab) as GameObject;
            newCard.GetComponentInChildren<Text>().text = trackables[t].GetComponent<Tracking>().trackableItems[tc]; 
            newCard.transform.SetParent(mCanvas.transform, false);

            activeCards.Add(newCard);         
            }

        }

    }

}
