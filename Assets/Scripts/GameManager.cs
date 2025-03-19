using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreR = 0;
    public int PlayerScoreL = 0;
    private int winScore = 100;
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;
    public TMP_Text txtPlayer1Win;
    public TMP_Text txtPlayer2Win;

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

        txtPlayer1Win.gameObject.SetActive(false);
        txtPlayer2Win.gameObject.SetActive(false);
    }

    public void Score(string wallID) {

        if (wallID == "Line_L") {

            PlayerScoreR = PlayerScoreR + 10; 
            txtPlayerScoreR.text = PlayerScoreR.ToString();

        } else{

            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
           
        }

        CheckIfWin();
    }

    void CheckIfWin() {

        if(PlayerScoreL >= winScore ) {

            txtPlayer1Win.gameObject.SetActive(true);
            Time.timeScale = 0;

        }else if(PlayerScoreR >= winScore ) {

            txtPlayer2Win.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
    }
}
