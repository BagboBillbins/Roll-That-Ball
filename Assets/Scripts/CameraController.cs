using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // Use this for initialization
    public GameObject player;
    private Vector3 offset;

	void Start ()
    {
        offset = transform.position - player.transform.position;
    }
	
	// LateUpdate is better for 3rd person view cameras
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
    }
}
