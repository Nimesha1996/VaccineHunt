using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VaccinePickUp : MonoBehaviour
{
    // Start is called before the first frame update
  IEnumerator  OnTriggerEnter ( Collider col  ){
 transform.position = new Vector3(0, -1000, 0);
 yield return new WaitForSeconds(2.9f);
		// Application.LoadLevel (3);
        SceneManager.LoadScene(4);


}
}


