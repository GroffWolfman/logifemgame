using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
	public GameObject TextBox;
	public GameObject Choice01;
	public GameObject Choice02;
	public GameObject Choice03;
	public int ChoiceMade;

	public void ChoiceOption1(){
		TextBox.GetComponent<Text>().text = "I got paid 80$, for a day's work.";
		ChoiceMade = 1;
	}

	public void ChoiceOption2(){
		TextBox.GetComponent<Text>().text = "One less thing to worry about.";
		ChoiceMade = 2;
	}

	public void ChoiceOption3(){
		TextBox.GetComponent<Text>().text = "No luck, so far.";
		ChoiceMade = 3;
	}


    // Update is called once per frame
    void Update()
    {
		if (ChoiceMade >= 1) {
			Choice01.SetActive (false);
			Choice02.SetActive (false);
			Choice03.SetActive (false);


		}
    }
}
