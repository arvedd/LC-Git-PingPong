using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public AudioSource audioPlayer;
    Animator animator;

    void Start() {
        
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);

        animator = GetComponent<Animator>();
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

    [SerializeField] private int wallCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.name == "Player") {

            audioPlayer.Play();
            rb2d.AddForce(new Vector2(20, -15));
            wallCollision = 0;

        }else if(collision.gameObject.name == "Enemy") {

            audioPlayer.Play();
            rb2d.AddForce(new Vector2(-20, -15));
            wallCollision = 0;

        } else {

            audioPlayer.Play();
            wallCollision = wallCollision + 1;
            Debug.Log("Wall Collision = " + wallCollision);
            
            if(wallCollision > 6) {

                GoBall();
            }
        }
    }

    private IEnumerator ExplodeAndReset() {
    
    animator.SetTrigger("IsExplode");

    yield return new WaitForSeconds(0.10f);

    ResetBall();
    animator.SetTrigger("IsIdle");
    wallCollision = 0;
    Invoke("GoBall", 1);

}

}
