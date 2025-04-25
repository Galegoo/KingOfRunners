using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

    public AudioSource clickSoun;
    public string mainMenuLevel;
    public Musica musicalink;

    void Awake()
    {
        musicalink = GameObject.Find("Menu Principal - Smoth Labyrinth (1)").GetComponent<Musica>();
    }
    public void RestartGame(){
        clickSoun.Play();
		FindObjectOfType<GameManager> ().Reset ();

	}

	public void QuitToMain(){
        clickSoun.Play();
        musicalink.bula = true;
        SceneManager.LoadScene(mainMenuLevel);

	}
}
