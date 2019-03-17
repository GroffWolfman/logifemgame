using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{

public string trackingType;
public List<string>  trackableItems= new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    SO, if we make a 2D list, we can basically indicate if there are any "blockers" to selecting
    and then we can alter them and make it so that if something is completed, we can unblock.
    We can also just have that structure set up and not have any blockers
    
     */
}
