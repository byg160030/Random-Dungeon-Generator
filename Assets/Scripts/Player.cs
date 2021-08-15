using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Transform GFX;
	float flipX;

	// Use this for initialization
	void Start () {
		GFX = GetComponentInChildren<SpriteRenderer>().transform;
		flipX = GFX.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		float horz =  System.Math.Sign(Input.GetAxisRaw("Horizontal"));
		if(Mathf.Abs(horz) > 0)
        {
			GFX.localScale = new Vector2(flipX * horz, GFX.localScale.y);
        }
	}
}
