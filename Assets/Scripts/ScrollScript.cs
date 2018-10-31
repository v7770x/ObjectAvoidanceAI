using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour {

    private float scrollSpeed = GameControllerScript.scrollSpeed;
    Rigidbody2D rgbd;

	// Use this for initialization
	void Start () {
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.velocity = new Vector2(0, -1 * scrollSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
