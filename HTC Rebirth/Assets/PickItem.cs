using UnityEngine;
using System.Collections;

public class PickItem : MonoBehaviour {

	private Rigidbody rb;
	private int score = 0;
	public GUIText scoreText;



	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	void Update ()
	{
		scoreText.text = "Score: " + score;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("Fire")) {
			Destroy (other.gameObject);
			score += 10;
			Debug.Log ("Le score est" + score);


		}

	}


}