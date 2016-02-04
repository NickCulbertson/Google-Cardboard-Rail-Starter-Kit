using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Transform[] target;
	public float speed;
	public int targetselect;

	// Use this for initialization
	void Start () {
		targetselect = 0;
		Camera.main.GetComponent<AudioSource>().Stop();
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;

			transform.position = Vector3.MoveTowards (transform.position, target[targetselect].position, step);

		if (transform.position == target [0].position) {
			targetselect = 1;
			speed = 3;
		} else if (transform.position == target [1].position) {
			targetselect = 2;
			speed = 2;

		} else if (transform.position == target [2].position) {
			targetselect = 3;
			speed = 3;
		} else if (transform.position == target [3].position) {
			targetselect = 4;
			speed = 8;

		} else if (transform.position == target [4].position) {
			targetselect = 5;
		} else if (transform.position == target [5].position) {
			targetselect = 6;
			Camera.main.GetComponent<AudioSource>().Stop();

		} else if (transform.position == target [6].position) {
			targetselect = 7;

		} else if (transform.position == target [7].position) {
			targetselect = 8;

		} else if (transform.position == target [8].position) {
			targetselect = 9;

		} else if (transform.position == target [9].position) {
			targetselect = 10;
			Camera.main.GetComponent<AudioSource>().Play();

		} else if (transform.position == target [10].position) {
			targetselect = 11;
			speed = 4;

		} else if (transform.position == target [11].position) {
			targetselect = 12;
			speed = 2;

		} else if (transform.position == target [12].position) {
			targetselect = 13;
			speed = 3;

		} else if (transform.position == target [13].position) {
			targetselect = 14;
			speed = 8;

		} else if (transform.position == target [14].position) {
			targetselect = 15;
	//		speed = 5;

		} else if (transform.position == target [15].position) {
			targetselect = 16;

		} else if (transform.position == target [16].position) {
			targetselect = 17;
			Camera.main.GetComponent<AudioSource>().Stop();

		} else if (transform.position == target [17].position) {
			targetselect = 18;
		} else if (transform.position == target [18].position) {
			targetselect = 19;
		} else if (transform.position == target [19].position) {
			targetselect = 20;
		} else if (transform.position == target [20].position) {
			targetselect = 21;
			Camera.main.GetComponent<AudioSource>().Play();

		} else if (transform.position == target [21].position) {
			targetselect = 22;
		} else if (transform.position == target [22].position) {
			targetselect = 23;
			speed = 4;

		} else if (transform.position == target [23].position) {
			targetselect = 24;

		} else if (transform.position == target [24].position) {
			targetselect = 0;
			speed = 0;
			Camera.main.GetComponent<AudioSource>().Stop();


		}
	}

	public void ChangeInt(){
		speed = 3;
		Camera.main.GetComponent<AudioSource>().Play();

	}
}
