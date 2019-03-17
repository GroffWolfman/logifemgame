using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour{


public string cellAttribute;
public bool isClicked;


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
          
            if (this.isClicked){
                whatDidIClick();
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
                {print( "YOU HIT NOTHING");}
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
    
}
