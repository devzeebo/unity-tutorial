using UnityEngine;
using System.Collections;

public class PlatformSpawner : MonoBehaviour {

    public GameObject PlatformTemplate;

    public float SpawnDelay = 3f;
    private float _spawnTimer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        _spawnTimer -= Time.deltaTime;

        if (_spawnTimer < 0) {
            _spawnTimer = SpawnDelay;

            GameObject platform = (GameObject)GameObject.Instantiate(PlatformTemplate, transform.position, Quaternion.identity);
            platform.transform.Translate(Vector3.up * (Random.value - 0.5f) * 2);
        }
	}
}
