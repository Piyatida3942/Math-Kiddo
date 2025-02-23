using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
	
	//Main menu 
	//game mode
	public void goToMainMenu()
	{
		SceneManager.LoadSceneAsync(0);
	}
	public void goToGameMode()
	{
		SceneManager.LoadSceneAsync(1);
	}
	//back
	public void back()
	{
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	//quit game
	public void quitGame()
	{
		Application.Quit();
	}

	
	//Records
	public void goToRecords()
	{
		SceneManager.LoadSceneAsync(2);
	}
	//Challenge
	public void goToChallenge()
	{
		SceneManager.LoadSceneAsync(3);
	}

	//Store
	public void goToStore()
	{
		SceneManager.LoadSceneAsync(4);
	}

	//Lavel
	public void goToLevel(){
		SceneManager.LoadSceneAsync(5);
	}
	//Game story
	public void StoryTime()
	{
		SceneManager.LoadSceneAsync(6);
	}

	//quiz 
	public void QuizTime()
	{
	SceneManager.LoadSceneAsync(7);
	}
}
