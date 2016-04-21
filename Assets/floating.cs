using UnityEngine;
using System.Collections;

public class floating : MonoBehaviour {
	public float FloatStrength;
	public float RandomRotationStrength;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		FloatStrength = Random.Range (0, 5f);
		RandomRotationStrength = Random.Range (0, 10f);
		GetComponent<Rigidbody>().AddForce (Vector3.up * FloatStrength);
		transform.Rotate (RandomRotationStrength, RandomRotationStrength, RandomRotationStrength);
	}
}
