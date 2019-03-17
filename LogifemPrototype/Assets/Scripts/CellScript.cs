﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour{


public string cellAttribute;
public bool isClicked;
public bool isActive;


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
          
            if (this.isClicked){
                whatDidIClick();
                onlyActiveCell();
                isClicked = false;
            }
        }

        //Perform function based on what type of cell this currently is
        void whatDidIClick(){
                if (this.CellHasTexture("keyTexture")){
                    {print( "keys");}
                }
                if (this.CellHasTexture("plannerTexture")){
                    {print( "plans");}
                }
        }


        bool CellHasTexture(string TextureInQuestion)
        {
            //first off does the cell have a texture/attribute
            if (cellAttribute == null){
                return false;
            } else {
            //now lets actually check it out
                if (TextureInQuestion == cellAttribute){
                    return true;
                } else {
                    return false;
                }
            }
        }

        void onlyActiveCell(){
            GameObject mBoard = GameObject.Find("Controller/TempBoard");
            for(int u =0; u < mBoard.GetComponent<PopulateBoardCell>().usableCells.Length; u++){
            mBoard.GetComponent<PopulateBoardCell>().usableCells[u].GetComponent<CellScript>().isActive = false;
            mBoard.GetComponent<PopulateBoardCell>().KeyCell.GetComponent<CellScript>().isActive = false;
            mBoard.GetComponent<PopulateBoardCell>().PlannerCell.GetComponent<CellScript>().isActive = false;
            }
            this.isActive =true;
        }


    
}
