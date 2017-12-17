
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Vector2 vel;

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

   
  void Update()
    {
        if(this.transform.position.x<=-4.36 || this.transform.position.x >= 4.36)
        {

            this.transform.position = new Vector3(0f, 0.15f, 1.23f);
           
           
        }
        
        


    }

   void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            vel.x = rb2d.velocity.x;
            vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = vel;
        }
    }

}
