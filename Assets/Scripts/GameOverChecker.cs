using UnityEngine;
using System.Collections;

public class GameOverChecker : MonoBehaviour {

    public GameObject ScoreGameObject;
    private Score Score;

    public GameObject GameOverMenu;
    
	// Use this for initialization
	void Start () {
        Score = ScoreGameObject.GetComponent<Score>();
	}

    void OnTriggerEnter2D(Collider2D other) {
        Score.IsScoring = false;
        GameOverMenu.SetActive(true);
    }

    public void RestartGame() {
        Application.LoadLevel(0);
    }
}
