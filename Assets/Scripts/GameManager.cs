using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreR = 0;
    public int PlayerScoreL = 0;
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameManager instance;

    public void Awake() {

        if(instance == null) {
            instance = this;

        }else {
            Destroy(gameObject);
        }
    }

    void Start() {

        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void Score(string wallID) {

        if (wallID == "Line_L") {

            PlayerScoreR = PlayerScoreR + 10; 
            txtPlayerScoreR.text = PlayerScoreR.ToString();

        } else{

            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
           
        }
    }
}
