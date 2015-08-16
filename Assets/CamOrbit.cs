using UnityEngine;
using System.Collections;

public class CamOrbit : MonoBehaviour {
	public float semiMaj;
	public float semiMin;
	private float theta;
	public GameObject origin;
	public float orbRad;
	public float speed;
	Vector3 old;
	// Use this for initialization
	void Start () {
		theta = 0;
		speed = 0;


	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Vector3.zero);
	
			
			

			if (Input.GetKeyDown (KeyCode.RightArrow)) {
			theta += speed;
			print ("ROTATE");
			old = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			move();
			rotate();	

		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			theta -= speed;
			old = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			move ();
			rotate();

		}
		if(Input.GetKeyDown(KeyCode.W))
		{
			speed+= 0.001f;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			speed-= 0.001f;
		}
			;
			

	
	}

	void rotate()
	{

	}
			void move()
			{
				float x = semiMaj * Mathf.Cos (theta);
				float z = semiMin * Mathf.Sin (theta);
				float y = transform.position.y;
				x = origin.transform.position.x + x;
				z = origin.transform.position.z + z;
				
				transform.position = new Vector3 (x, y, z);
			}
}
