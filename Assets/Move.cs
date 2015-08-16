using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float direction;
	float theta;
	// Use this for initialization
	void Start () {
		theta = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		float xAxisValue = Input.GetAxis("Horizontal");
		float zAxisValue = Input.GetAxis("Vertical");
		if(Camera.current != null)
		{
			Camera.current.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
		}

	}
}
