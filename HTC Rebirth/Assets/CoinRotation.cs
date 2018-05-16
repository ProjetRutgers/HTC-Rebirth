using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {


	
	// Update is called once per frame
	void FixedUpdate ()
	{
		transform.Rotate(Vector3.up);
	}
}
