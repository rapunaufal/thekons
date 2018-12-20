using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {
    private static GameObject pleyer;
    public static GameObject decision_mampir, decision_lanjut,winning_text, btn_restart, btn_trap, btn_acak, btn_skill,btn_jalan;
    public static int playerstartwaypoint = 0, diceside = 0, sisadadu = 0, daduenam = 0, totaldadu = 0;
    public static bool temp = false, lanjut = false, mampir = false, enam = false, ceksisadadu = false;
    public static bool card1 = false, card2 = false, card3 = false, card4 = false, card5 = false, card6 = false, card7 = false, card8 = false, card9 = false, card10 = false, card11 = false, card12 = false, card13 = false, card14 = false, card15 = false, card16 = false, card17 = false;
    // Use this for initialization
    void Start () {
        pleyer = GameObject.Find("Player");
        decision_lanjut = GameObject.Find("btn_decision_lnjt");
        decision_mampir = GameObject.Find("btn_decision_mampir");
        winning_text = GameObject.Find("Winning_Text");
        btn_restart = GameObject.Find("btn_restart");
        btn_trap = GameObject.Find("btn_trap");
        btn_acak = GameObject.Find("btn_acak");
        btn_skill = GameObject.Find("btn_skill");
        btn_jalan = GameObject.Find("btn_jalan");
        pleyer.GetComponent<FollowThePath>().moveAllowed = false;
        decision_lanjut.gameObject.SetActive(false);
        decision_mampir.gameObject.SetActive(false);
        winning_text.gameObject.SetActive(false);
        btn_restart.gameObject.SetActive(false);
        btn_skill.gameObject.SetActive(false);
        btn_acak.gameObject.SetActive(false);
        btn_trap.gameObject.SetActive(false);
    }

    public static void setPower(int pow)
    {
        switch (pow)
        {
            case 1:
                card1 = true;
                break;
            case 2:
                card2 = true;
                break;
            case 3:
                card3 = true;
                break;
            case 4:
                card4 = true;
                break;
            case 5:
                card5 = true;
                break;
            case 6:
                card6 = true;
                break;
            case 7:
                card7 = true;
                break;
            case 8:
                card8 = true;
                break;
            case 9:
                card9 = true;
                break;
            case 10:
                card10 = true;
                break;
            case 11:
                card11 = true;
                break;
            case 12:
                card12 = true;
                break;
            case 13:
                card13 = true;
                break;
            case 14:
                card14 = true;
                break;
            case 15:
                card15 = true;
                break;
            case 16:
                card16 = true;
                break;
            case 17:
                card17 = true;
                break;
        }
    }

    // Update is called once per frame
    void Update () {

        if (card1)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex += 1;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;

            card1 = false;
        }
        if (card2)
        {


            card2 = false;
        }
        if (card3)
        {


            card3 = false;
        }
        if (card4)
        {


            card4 = false;
        }
        if (card5)
        {


            card5 = false;
        }
        if (card6)
        {


            card6 = false;
        }
        if (card7)
        {


            card7 = false;
        }
        if (card8)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex -= 1;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;

            card8 = false;
        }
        if (card9)
        {


            card9 = false;
        }
        if (card10)
        {


            card10 = false;
        }
        if (card11)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex -= 3;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            card11 = false;
        }
        if (card12)
        {

            card12 = false;
        }
        if (card13)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex -= 1;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            card13 = false;
        }
        if (card14)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex -= 2;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            card14 = false;
        }
        if (card15)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex += 3;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            card15 = false;
        }
        if (card16)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex += 2;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            card16 = false;
        }
        if (card17)
        {
            pleyer.GetComponent<FollowThePath>().waypointIndex += 1;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            card17 = false;
        }






        //jika berhenti pada kotak acak
        if ((pleyer.GetComponent<FollowThePath>().waypointIndex == 2 || pleyer.GetComponent<FollowThePath>().waypointIndex == 12 
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 22 || pleyer.GetComponent<FollowThePath>().waypointIndex == 30
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 34 || pleyer.GetComponent<FollowThePath>().waypointIndex == 43
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 50 || pleyer.GetComponent<FollowThePath>().waypointIndex == 60
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 73 || pleyer.GetComponent<FollowThePath>().waypointIndex == 89
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 101 || pleyer.GetComponent<FollowThePath>().waypointIndex == 111
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 123 || pleyer.GetComponent<FollowThePath>().waypointIndex == 140
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 150 || pleyer.GetComponent<FollowThePath>().waypointIndex == 168)
            && (pleyer.GetComponent<FollowThePath>().waypointIndex > playerstartwaypoint + diceside - sisadadu))
        {
            btn_acak.gameObject.SetActive(true);
            btn_jalan.gameObject.SetActive(false);
        }

        //jika berhenti pada kotak Skill
        if ((pleyer.GetComponent<FollowThePath>().waypointIndex == 8 || pleyer.GetComponent<FollowThePath>().waypointIndex == 19 
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 27 || pleyer.GetComponent<FollowThePath>().waypointIndex == 32
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 52 || pleyer.GetComponent<FollowThePath>().waypointIndex == 67
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 76 || pleyer.GetComponent<FollowThePath>().waypointIndex == 81
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 92 || pleyer.GetComponent<FollowThePath>().waypointIndex == 108
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 117 || pleyer.GetComponent<FollowThePath>().waypointIndex == 127
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 144 || pleyer.GetComponent<FollowThePath>().waypointIndex == 157
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 169)
            && (pleyer.GetComponent<FollowThePath>().waypointIndex > playerstartwaypoint + diceside - sisadadu))
        {
            btn_skill.gameObject.SetActive(true);
            btn_jalan.gameObject.SetActive(false);
        }

        //jika berhenti pada kotak trap
        if ((pleyer.GetComponent<FollowThePath>().waypointIndex == 5 || pleyer.GetComponent<FollowThePath>().waypointIndex == 18
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 20 || pleyer.GetComponent<FollowThePath>().waypointIndex == 31
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 33 || pleyer.GetComponent<FollowThePath>().waypointIndex == 40
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 48 || pleyer.GetComponent<FollowThePath>().waypointIndex == 58
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 65 || pleyer.GetComponent<FollowThePath>().waypointIndex == 78
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 94 || pleyer.GetComponent<FollowThePath>().waypointIndex == 106
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 120 || pleyer.GetComponent<FollowThePath>().waypointIndex == 135
            || pleyer.GetComponent<FollowThePath>().waypointIndex == 153 || pleyer.GetComponent<FollowThePath>().waypointIndex == 163)
            && (pleyer.GetComponent<FollowThePath>().waypointIndex > playerstartwaypoint + diceside - sisadadu))
        {
            btn_trap.gameObject.SetActive(true);
            btn_jalan.gameObject.SetActive(false);
        }



        //kalo ketemu percabangan
        if ((pleyer.GetComponent<FollowThePath>().waypointIndex == 7 || pleyer.GetComponent<FollowThePath>().waypointIndex == 18 || pleyer.GetComponent<FollowThePath>().waypointIndex == 30 || pleyer.GetComponent<FollowThePath>().waypointIndex == 79 || pleyer.GetComponent<FollowThePath>().waypointIndex == 125) && !temp)
        {
            sisadadu = pleyer.GetComponent<FollowThePath>().telahberlalu - 1;
            pleyer.GetComponent<FollowThePath>().cekangka = diceside - sisadadu;
            if ((diceside - sisadadu-1) > 0)
            {
                //pleyer.GetComponent<FollowThePath>().cekangka = 2727272;
                pleyer.GetComponent<FollowThePath>().moveAllowed = false;
                decision_lanjut.gameObject.SetActive(true);
                decision_mampir.gameObject.SetActive(true);
            }
            else
            {
                ceksisadadu = true;
            }
        }
        //selain ketemu percabangan
        if ((pleyer.GetComponent<FollowThePath>().waypointIndex > 7 && pleyer.GetComponent<FollowThePath>().waypointIndex < 18) || (pleyer.GetComponent<FollowThePath>().waypointIndex > 18 && pleyer.GetComponent<FollowThePath>().waypointIndex < 30)
             || (pleyer.GetComponent<FollowThePath>().waypointIndex > 30 && pleyer.GetComponent<FollowThePath>().waypointIndex < 79)
              || (pleyer.GetComponent<FollowThePath>().waypointIndex > 79 && pleyer.GetComponent<FollowThePath>().waypointIndex < 125))
        {
            temp = false;
        }
        //kalo ngeklik mampir
        if (mampir)
        {
            decision_lanjut.gameObject.SetActive(false);
            decision_mampir.gameObject.SetActive(false);
            if (diceside - sisadadu > 0)
            {
                pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            }
            mampir = false;
            temp = true;
        }
        //kalo ngeklik lanjut
        if (lanjut)
        {
            if (pleyer.GetComponent<FollowThePath>().waypointIndex == 7 || pleyer.GetComponent<FollowThePath>().waypointIndex == 18)
            {
                pleyer.GetComponent<FollowThePath>().waypointIndex += 1;
                playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            }
            else
            {
                pleyer.GetComponent<FollowThePath>().waypointIndex += 3;
                playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex - 1;
            }
            decision_lanjut.gameObject.SetActive(false);
            decision_mampir.gameObject.SetActive(false);
            pleyer.GetComponent<FollowThePath>().moveAllowed = true;
            lanjut = false;
        }

        //langkah sesuai dadu
        if (pleyer.GetComponent<FollowThePath>().waypointIndex > playerstartwaypoint + diceside - sisadadu)
        {
            pleyer.GetComponent<FollowThePath>().moveAllowed = false;
            playerstartwaypoint = pleyer.GetComponent<FollowThePath>().waypointIndex-1;
        }
        //end
        if (pleyer.GetComponent<FollowThePath>().waypointIndex == pleyer.GetComponent<FollowThePath>().waypoints.Length)
        {
            winning_text.gameObject.SetActive(true);
            btn_restart.gameObject.SetActive(true);
        }
        
	}


    public static void MoveStop()
    {
        pleyer.GetComponent<FollowThePath>().moveAllowed = false;
    }
    public static void MovePlayer()
    {
        pleyer.GetComponent<FollowThePath>().telahberlalu = 0;
        pleyer.GetComponent<FollowThePath>().moveAllowed = true;
    }
    public static void MoveLanjut()
    {
        //pleyer.GetComponent<FollowThePath>().moveAllowed = true;

    }
    public static void MoveMampir()
    {
        //pleyer.GetComponent<FollowThePath>().moveAllowed = true;
    }
    
}
