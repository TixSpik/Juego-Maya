using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public float speed = 4f;
    Rigidbody2D rb2d;
    Animator anim;
    Vector2 movi;
    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

     movi= new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movi !=Vector2.zero)
        {
        anim.SetFloat("MoveX", movi.x);
        anim.SetFloat("MoveY", movi.y);
        anim.SetBool("Walking", true);

        }
        else
        {
            anim.SetBool("Walking", false);
        }

      
	}

     void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movi * speed * Time.deltaTime);
    }



}
