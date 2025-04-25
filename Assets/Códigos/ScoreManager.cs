using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;

	public float scoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing;

	
	// Update is called once per frame
	void Update () {

		if (scoreIncreasing) {
			scoreCount += pointsPerSecond * Time.deltaTime;
		}

		scoreText.text = "Score: " + Mathf.Round (scoreCount);
	
	}
	public void AddScore(int pointsToAdd)
	{
		scoreCount += pointsToAdd;
	}
}
