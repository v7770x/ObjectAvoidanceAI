using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Car : MonoBehaviour {

	// Use this for initialization
    Rigidbody2D rb2d;
    public float speed;
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //rb2d.velocity = new Vector2(0, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb2d.velocity = new Vector2(speed*1, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(speed*-1, 0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow)|| Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb2d.velocity = new Vector2(speed * 0, 0);
        }
     
    }
}
