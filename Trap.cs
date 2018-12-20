using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Trap : MonoBehaviour {
    public static int hasil_Trap;
    public GameObject Terep,card4;
    Image gambar;
    Sprite spr;
    // Use this for initialization
    void Start () {
        Terep.SetActive(false);
        rend = Terep.GetComponent<SpriteRenderer>();
        TrapSides = Resources.LoadAll<Sprite>("TrapCard/");
        rend.sprite = TrapSides[0];
        gambar = card4.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private Sprite[] TrapSides;
    private SpriteRenderer rend;
    private bool coroutineAllowed = true;

    public void start()
    {
        Terep.SetActive(true);
        if (coroutineAllowed)
            StartCoroutine("RollTheTrap");
    }
    private void OnMouseDown()
    {
        Terep.SetActive(false);

        gambar.sprite = spr;
    }

    private IEnumerator RollTheTrap()
    {
        coroutineAllowed = false;
        int randomTrapSide = 0;
        for (int i = 0; i < 25; i++)
        {
            randomTrapSide = Random.Range(0, 5);
            rend.sprite = TrapSides[randomTrapSide];
            yield return new WaitForSeconds(0.05f);
        }
        spr = rend.sprite;

        hasil_Trap = randomTrapSide + 1;
        coroutineAllowed = true;
    }
}
