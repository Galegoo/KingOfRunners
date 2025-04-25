using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform plataformGenerator;
	public Vector3 plataformStartPoint;

	public PlayerController thePlayer;
	public Vector3 playerStartPoint;

	public Transform gramaGenerator;
	public Vector3 gramaGeneratorOriginPoint;
		
	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;

    public PlataformDestroyer[] destroyerList;

	void Start () {
		plataformStartPoint = plataformGenerator.position;
		playerStartPoint = thePlayer.transform.position;
		gramaGeneratorOriginPoint = gramaGenerator.transform.position;
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}

	void Update () {
	
	}

	public void RestartGame()
	{
		theScoreManager.scoreIncreasing = false;
		thePlayer.gameObject.SetActive(false);

		theDeathScreen.gameObject.SetActive (true);

	}

	public void Reset(){
		theDeathScreen.gameObject.SetActive (false);
        destroyerList = FindObjectsOfType<PlataformDestroyer>();
        for (int i = 0; i < destroyerList.Length; i++)
        {
            destroyerList[i].gameObject.SetActive(false);
        }

				
		thePlayer.transform.position = playerStartPoint;
		plataformGenerator.position = plataformStartPoint;
		gramaGenerator.position = gramaGeneratorOriginPoint;
		thePlayer.gameObject.SetActive (true);
		
		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;

	}

}
