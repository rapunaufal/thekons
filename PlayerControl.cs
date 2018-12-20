using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void jalan()
    {

        if (GameControl.ceksisadadu)
        {
            GameControl.decision_lanjut.gameObject.SetActive(true);
            GameControl.decision_mampir.gameObject.SetActive(true);
            GameControl.MoveStop();
        }
        var dadu = Dadu.hasil_dadu;
        GameControl.diceside = dadu;
        GameControl.sisadadu = 0;
        GameControl.lanjut = false;
        GameControl.mampir = false;
        GameControl.MovePlayer();
    }
    public void lanjut()
    {
        GameControl.ceksisadadu = false;
        GameControl.lanjut = true;
        GameControl.temp = true;
        GameControl.MoveLanjut();
    }
    public void mampir()
    {
        if (GameControl.ceksisadadu)
        {
            GameControl.sisadadu++;
            GameControl.ceksisadadu = false;
        }
        GameControl.mampir = true;
        GameControl.temp = true;
        GameControl.MoveMampir();
    }
    public void pencet_acak()
    {
        GameControl.btn_jalan.gameObject.SetActive(true);
        GameControl.btn_acak.gameObject.SetActive(false);
    }
    public void pencet_skill()
    {
        GameControl.btn_jalan.gameObject.SetActive(true);
        GameControl.btn_skill.gameObject.SetActive(false);
    }
    public void pencet_trap()
    {
        GameControl.btn_jalan.gameObject.SetActive(true);
        GameControl.btn_trap.gameObject.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
