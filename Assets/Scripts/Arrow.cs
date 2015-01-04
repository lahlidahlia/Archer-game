using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
    public bool is_enemy_arrow;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (is_enemy_arrow) {

        }
        else {
            if (col.tag == "Enemy") {
                Destroy(col.gameObject);
                Destroy(gameObject);
            }
        }
    }
}
