using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour {

	public Transform player;
    private bool playerIsOverlapping = false;

	void Update () 
	{
		if(playerIsOverlapping)
        {   
			player.position = new Vector3 (-6f, 6f, 8f);
			playerIsOverlapping = false;
        }
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player" )
        {
            playerIsOverlapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverlapping = false;
        }
    }
}
