using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public string mainMenuLevel;
	public GameObject pauseMenu;
    public AudioSource clickSom;
    public Musica musicalink;

    void Awake()
    {
        musicalink = GameObject.Find("Menu Principal - Smoth Labyrinth (1)").GetComponent<Musica>();
    }

    public void PauseGame (){
        clickSom.Play();
		Time.timeScale = 0f;
		pauseMenu.SetActive(true);
	}

	public void continuar(){
        clickSom.Play();
        Time.timeScale = 1f;
		pauseMenu.SetActive(false);
		}

	public void RestartGame(){
        clickSom.Play();
        pauseMenu.SetActive(false);
		Time.timeScale = 1f;
		FindObjectOfType<GameManager> ().Reset ();	
	}
	
	public void QuitToMain(){
        clickSom.Play();
        musicalink.bula = true;
        Time.timeScale = 1f;
		Application.LoadLevel (mainMenuLevel);
		
	}
    void Update()
    {
        DontDestroyOnLoad(clickSom);
    }
}
