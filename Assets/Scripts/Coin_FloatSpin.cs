using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_FloatSpin : MonoBehaviour {
	
	void Start () {
		float offset = Random.value;
		
		transform.Rotate(new Vector3(0, 0, 45) * Random.value);
		transform.Translate(0.01f * Vector3.up * Mathf.Cos(Random.value * 3f), Space.World);
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
		transform.Translate(0.01f * Vector3.up * Mathf.Cos(Time.fixedTime * 3f), Space.World);
	}
}
