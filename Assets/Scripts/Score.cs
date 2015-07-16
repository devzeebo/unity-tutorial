using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public bool IsScoring = true;

    public float ScoreValue;

    private Text ScoreText;

	// Use this for initialization
	void Start () {
        ScoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        if (IsScoring) {
            ScoreValue += Platform.PlatformSpeed * GameSpeed.Speed * Time.deltaTime;

            ScoreText.text = string.Format("Score: {0:0.00}", ScoreValue);
        }
	}
}
