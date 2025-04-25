using UnityEngine;
using System.Collections;

public class MenuPrincipal : MonoBehaviour {

	public string playGameLevel;
	public string playGameLevel2;
	public string playGameLevel3;
	public string playGameLevel4;
	public string playGameLevel5;
    public Musica musicalink;
    public AudioSource clickSound;

    void Awake()
    {
        musicalink = GameObject.Find("Menu Principal - Smoth Labyrinth (1)").GetComponent<Musica>();
    }
    public void JogarNivel1()
	{
        clickSound.Play();
        musicalink.bula = false;
        Application.LoadLevel (playGameLevel);
        
		}
	public void JogarNivel2()
	{
        clickSound.Play();
        musicalink.bula = false;
        Application.LoadLevel (playGameLevel5);
        
    }
	public void Jogar()
	{
        clickSound.Play();
        Application.LoadLevel (playGameLevel4);
	}

	public void Instrucoes()
	{
        clickSound.Play();
        Application.LoadLevel (playGameLevel2);
	}

	public void Creditos()
	{
        clickSound.Play();
        Application.LoadLevel (playGameLevel3);
		
	}

	public void Sair()
	{
        clickSound.Play();
        Application.Quit ();
		
	}
	
	void Update()
    {
        DontDestroyOnLoad(clickSound);
    }
}
