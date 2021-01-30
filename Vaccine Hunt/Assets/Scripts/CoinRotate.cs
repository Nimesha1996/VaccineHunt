using UnityEngine;
using System.Collections;

public class CoinRotate : MonoBehaviour {
void  Update (){
 transform.Rotate(0, 2, 0, Space.World);
}
}