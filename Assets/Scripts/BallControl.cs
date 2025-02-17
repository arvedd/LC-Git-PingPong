using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start() {
        
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }

    void GoBall() {

        float rand = Random.Range(0, 2);

        if(rand < 1) {
            
            rb2d.AddForce(new Vector2(20, -15));
        
        }else {

            rb2d.AddForce(new Vector2(-20, -15));

        }
    }

    void ResetBall() {

        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame() {

        ResetBall();
        Invoke("GoBall", 1);

    }

    [SerializeField] private int wallCollision;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "King") {

            rb2d.AddForce(new Vector2(20, -15));
            wallCollision = 0;

        }else if(collision.gameObject.name == "Pig") {

            rb2d.AddForce(new Vector2(-20, -15));
            wallCollision = 0;

        }else {

            wallCollision = wallCollision + 1;
            Debug.Log("Wall Collision = " + wallCollision);
            
            if(wallCollision > 6) {

                GoBall();
            }
        }

    }
}
