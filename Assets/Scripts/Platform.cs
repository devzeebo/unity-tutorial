using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

    public static float PlatformSpeed = 0f;

    public float PlatformWidth = 1f;

    public float PlatformHeight = 1f;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(PlatformWidth, PlatformHeight);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * Time.deltaTime * PlatformSpeed);
	}
}
