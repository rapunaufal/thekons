using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Power : MonoBehaviour {
    public static int hasil_power;
    public GameObject power,card1,card2,card3;
    Image gambar1,gambar2,gambar3;
    Sprite spr;
    // Use this for initialization
    void Start () {
        power.SetActive(false);
        rend = power.GetComponent<SpriteRenderer>();
        powerSides = Resources.LoadAll<Sprite>("PowerCard/");
        rend.sprite = powerSides[0];
        gambar1 = card1.GetComponent<Image>();
        gambar2 = card2.GetComponent<Image>();
        gambar3 = card3.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private Sprite[] powerSides;
    private SpriteRenderer rend;
    private bool coroutineAllowed = true;

    public void start()
    {
        power.SetActive(true);
        if (coroutineAllowed)
            StartCoroutine("RollThePower");
    }
    private void OnMouseDown()
    {
        power.SetActive(false);
        gambar3.sprite = gambar2.sprite;
        gambar2.sprite = gambar1.sprite;
        gambar1.sprite = spr;

    }

    private IEnumerator RollThePower()
    {
        coroutineAllowed = false;
        int randomPowerSide = 0;
        for (int i = 0; i < 50; i++)
        {
            randomPowerSide = Random.Range(0, 17);
            rend.sprite = powerSides[randomPowerSide];
            yield return new WaitForSeconds(0.05f);
        }
        spr = rend.sprite;

        hasil_power = randomPowerSide + 1;
        pencetKartu.setPowerNumber(hasil_power);
        coroutineAllowed = true;
    }

}
