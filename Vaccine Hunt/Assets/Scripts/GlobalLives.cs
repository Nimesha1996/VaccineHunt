using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalLives : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public GameObject LifeTextBox;
    public static int LivesAmount = 3;
    public int InternalLives ;
    void Update()
    {
    InternalLives = LivesAmount;
	LifeTextBox.GetComponent<UnityEngine.UI.Text>().text ="LIVES: " + InternalLives;

	if (InternalLives == 0) {
		GameOverScene();
	}
    }

    IEnumerator GameOverScene (){
        yield return new WaitForSeconds(2.9f);
		// Application.LoadLevel (3);
        SceneManager.LoadScene(3);
    }
}

