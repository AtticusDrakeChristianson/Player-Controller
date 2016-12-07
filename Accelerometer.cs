//I used this to move my player by tilting my Android device.
using UnityEngine;
using System.Collections;

public class acc : MonoBehaviour {

	public float speed = 3f;

	void start() {

	}

	void Update () {

		transform.Translate(0, 0, 

			(-1 * Input.acceleration.z *speed * Time.deltaTime)); // adds movement on the Z axis alone.
		var x = Input.acceleration.x * Time.deltaTime * 150.0f;
		transform.Rotate (0, x, 0);
	}
}
