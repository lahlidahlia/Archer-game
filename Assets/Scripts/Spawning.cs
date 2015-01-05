using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {
    private float timer;
    public float spawn_frequency; //How often an enemy is spawned (in seconds)
    public GameObject enemy;
	// Use this for initialization
	void Start () {
        timer = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time - timer > spawn_frequency) {
            Vector2 location = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, ((Random.value * 0.5f) + 1.5f)));

            Instantiate(enemy, location, Quaternion.identity);
            timer = Time.time;
        }
	}


}
