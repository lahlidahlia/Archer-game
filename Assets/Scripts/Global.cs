using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {
    public static int FPS = 60;

	void Start () {
        Application.targetFrameRate = FPS;
	}
}
