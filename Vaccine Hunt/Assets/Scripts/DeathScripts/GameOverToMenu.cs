using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
    yield return new WaitForSeconds (4);
	GlobalLives.LivesAmount += 3;
	SceneManager.LoadScene(2);
    }

  
}
