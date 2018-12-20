using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowThePath : MonoBehaviour {
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;
    [HideInInspector]
    public int waypointIndex = 0;
    public int tambah_lanjut = 0;
    public bool moveAllowed = false;
    public int telahberlalu = 0;
    public int cekangka = 0;
    // Use this for initialization
    void Start () {
        transform.position = waypoints[waypointIndex].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (moveAllowed)
        {
            Move();
        }
	}

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
                telahberlalu++;
            }
                    
            //}

        }
    }
}
