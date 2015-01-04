using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    private string state;
    private float timer; //Timer varaible
    public float battle_move_frequency; //How often enemy moves around in battle mode (in seconds)
    public float battle_move_range; //How far can the enemy move randomly
    private Vector2 destination;
    private bool movement_chosen = false; //Determines whether destination has already been chosen for that move cycle
    public float speed;
	// Use this for initialization
	void Start () {
        timer = Time.time;
        state = "battle";

	}
	
	// Update is called once per frame
	void Update () {
        if (state == "battle") {
            if (Time.time - timer > battle_move_frequency) { //If it's time to move again
                //Movement
                if (!movement_chosen) { 
                    //Choose a destination
                    Vector2 d = Random.insideUnitCircle * battle_move_range;
                    Debug.Log(d.magnitude);
                    destination = new Vector2(transform.position.x + d.x, transform.position.y + d.y);

                    movement_chosen = true;
                    timer = Time.time; //Timer reset
                }
                if (move_to(destination, speed)) {
                    movement_chosen = false;
                }
            }
        }
	}

    bool move_to(Vector2 destination, float speed) {
        /* Move toward a given destination
         * returns whether destination is reached (true if reached)
         */
        if (new Vector2(transform.position.x, transform.position.y) != destination) { //If destination isn't reached yet
            Vector2 movement = Vector2.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            transform.position = new Vector3(movement.x, movement.y, transform.position.z); //Move toward destination
            return false;
        }
        else {
            return true; //Destination reached
        }
    }

}
