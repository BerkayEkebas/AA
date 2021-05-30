using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour 
{
	public void yeniOyun()
	{
		    PlayerPrefs.DeleteAll ();
			SceneManager.LoadScene ("1");

	}
	public void oyunaGit()
	{
		int kayitiLevel = PlayerPrefs.GetInt ("kayit");
		if (kayitiLevel == 0) {
			SceneManager.LoadScene (kayitiLevel + 1);
		} 
		else {
			SceneManager.LoadScene (kayitiLevel);
		}

	}
	public void cik()
	{
		Debug.Log ("Çıkış");
		Application.Quit ();
	}

}
