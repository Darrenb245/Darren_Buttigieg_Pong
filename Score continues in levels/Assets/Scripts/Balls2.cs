using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls2 : MonoBehaviour {

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

    float time = -1;
    void Update()
    {
        if (this.transform.position.x <= -6.55 || this.transform.position.x >=6.55)
        {
            this.transform.position = new Vector3(-0.04f, 0.36f, 1.23f);
            time = 1;

        }
        if (time > 0)
        {
            time -= Time.deltaTime;
            this.transform.position = new Vector3(-0.04f, 0.36f, 1.23f);
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


