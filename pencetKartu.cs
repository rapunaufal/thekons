using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pencetKartu : MonoBehaviour, IPointerDownHandler {

    public GameObject tombol;
    public GameObject gambarKartu;
    Image gambar;
    Sprite spr;
    private static int pow;

    // Use this for initialization
    void Start () {
        tombol = GameObject.Find("Button");
        gambar = gambarKartu.GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void setPowerNumber(int a)
    {
        pow = a;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        spr = Resources.Load<Sprite>("Gambar/dasar");
        Debug.Log(gambarKartu.name + " ");
        gambar.sprite = spr;
        GameControl.setPower(pow);
        tombol.SetActive(false);
    }

}
