using UnityEngine;
using System.Collections;

public class TinScript {
    /*Utility Script made by Tin for Unity*/
    static Vector2 viewport_to_world(Camera c, Vector2 point) {
        /*Convert vieweport point of camera into world coordinate*/
        Vector2 ret = c.ViewportToWorldPoint(point);
        return ret;
    }
}
