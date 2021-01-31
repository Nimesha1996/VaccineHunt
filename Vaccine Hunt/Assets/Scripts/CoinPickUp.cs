using UnityEngine;
using System.Collections;



public class CoinPickUp : MonoBehaviour {

public AudioSource coinSFX;

void  OnTriggerEnter ( Collider col  ){
 transform.position = new Vector3(0, -1000, 0);
 GlobalCoins.CoinCount += 1;
 coinSFX.Play();
}
}
