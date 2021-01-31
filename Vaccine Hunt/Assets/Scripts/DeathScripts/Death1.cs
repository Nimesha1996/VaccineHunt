using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    AudioSource DeathSound;
    GameObject LevelMusic;
    
   IEnumerator  OnTriggerEnter ( Collider col  ){
       GlobalLives.LivesAmount -= 1;
	// LevelMusic.SetActive(false);
	// DeathSound.Play();
	yield return new WaitForSeconds(3);
	SceneManager.LoadScene(0);
}
}

