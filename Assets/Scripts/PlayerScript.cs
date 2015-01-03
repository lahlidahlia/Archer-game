using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lookAt(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition));
	}

    void lookAt(Vector3 objPos, Vector3 target) {
        /*Makes the object rotate toward the given point
         *Example usage: lookAt(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)); //Object looks at mouse
         * 
         */

        //Vector2.angle here is used to get the angle between the (0,1) vector(a vertical line) and the vector between the object and the mouse
        if (transform.position.x < target.x) { //If the mouse is on the right side of the object

            //Make the angle negative (e.g. if the mouse position relative to the object is (1,1), vector2.angle((0,1),(1,1)) would return 45, which is facing the left side.
            //If we make that number negative, it would face the right side.
            transform.rotation = Quaternion.Euler(0, 0, -Vector2.Angle(new Vector2(0, 1), target - objPos));
        }
        if (transform.position.x > target.x) { //If the mouse is on the left side of the object
            transform.rotation = Quaternion.Euler(0, 0, Vector2.Angle(new Vector2(0, 1), target - objPos));
        }
    }
}
