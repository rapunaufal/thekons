using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dadu : MonoBehaviour {
    public static int hasil_dadu;
    public GameObject dadu;
    // Use this for initialization
    void Start () {
        rend = dadu.GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[0];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    //private int whosTurn = 1;
    private bool coroutineAllowed = true;
    

    void OnMouseDown()
    {
        if (coroutineAllowed)
            StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i < 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        hasil_dadu = randomDiceSide + 1;
        //if (whosTurn == 1)
        //{
        //    GameControl.MovePlayer(1);
        //}
        //else if (whosTurn == -1)
        //{
        //    GameControl.MovePlayer(2);
        //}
        //whosTurn *= -1;
        coroutineAllowed = true;
    }
}
