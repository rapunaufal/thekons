using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCards : MonoBehaviour {

    public GameObject cardStack;
    bool isOpen = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MunculKartu ()
    {
        if (isOpen)
        {
            cardStack.SetActive(false);
            isOpen = false;
        }
        else
        {
            cardStack.SetActive(true);
            isOpen = true;
        }
    }

}
