using UnityEngine;
using System.Collections;

public class PlatformController : MonoBehaviour {

    public GameObject PlatformTemplate;

    public float PlatformSpeedRamp;

    public float PlatformSpeed;

    public float PlatformSpawnTime;

    public float PlatformMinLength = 5f;
    public float PlatformMaxLength = 30f;

    private float PlatformMinHeight;
    private float PlatformMaxHeight;

	// Use this for initialization
	void Start () {
        PlatformMinHeight = transform.Find("Min Height").position.y;
        PlatformMaxHeight = transform.Find("Max Height").position.y;
	}
	
	// Update is called once per frame
	void Update () {
        PlatformSpeed += PlatformSpeed * PlatformSpeedRamp * Time.deltaTime;
        Platform.PlatformSpeed = PlatformSpeed;

        PlatformSpawnTime -= Time.deltaTime * GameSpeed.Speed;

        if (PlatformSpawnTime < 0) {
            float platformWidth = Mathf.Lerp(PlatformMinLength, PlatformMaxLength, Random.value);
            platformWidth += Mathf.Sqrt(PlatformSpeed);

            PlatformSpawnTime = platformWidth / PlatformSpeed + Mathf.Lerp(0.5f, 1.1f, Random.value);

            float yOffset = Mathf.Lerp(-2, 2, Random.value);
            float newY = Mathf.Clamp(transform.position.y + yOffset, PlatformMinHeight, PlatformMaxHeight);
            transform.position = new Vector3(transform.position.x, newY, 0);

            Vector3 spawnPosition = transform.position;
            spawnPosition.x += platformWidth / 2;
            
            GameObject platform = (GameObject)GameObject.Instantiate(PlatformTemplate, spawnPosition, Quaternion.identity);
            platform.GetComponent<Platform>().PlatformWidth = platformWidth;
        }
	}
}
