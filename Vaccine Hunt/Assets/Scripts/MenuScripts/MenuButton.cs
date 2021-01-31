using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    void  PlayGame (){
	SceneManager.LoadScene(0);
}

    void  QuitGame (){
	Application.Quit();
}

}
