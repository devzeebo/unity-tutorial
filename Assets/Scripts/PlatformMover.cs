using UnityEngine;
using System.Collections;

public class PlatformMover : MonoBehaviour {

    public static float PlatformSpeed = 10f;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * PlatformSpeed);
	}
}
