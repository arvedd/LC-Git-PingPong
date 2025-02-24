using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D hitInfo) {

        if(hitInfo.name == "Ball") {

            string wallName = transform.name;
            GameManager.instance.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
