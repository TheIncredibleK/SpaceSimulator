using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {
	public float semiMaj;
	public float semiMin;
	private float theta;
	public GameObject origin;
	public float orbRad;
	public float speed;
	// Use this for initialization
	void Start () {
		theta = 0;


	
	}
	
	// Update is called once per frame
	void Update () {
	
			float x = semiMaj * Mathf.Cos (theta);
			float z = semiMin * Mathf.Sin (theta);
			theta += speed;
			float y = transform.position.y;
			x = origin.transform.position.x + x;
			z = origin.transform.position.z + z;
			transform.position = new Vector3 (x, y, z);
	//		print (transform.position);

	
	}
}
