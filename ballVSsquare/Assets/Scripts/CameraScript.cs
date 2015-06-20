using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	GameObject playerPos;
	Vector3 offset;
	// Use this for initialization
	void Start () {

		playerPos = GameObject.FindWithTag ("Player");
		offset = new Vector3 (5, 8, -4);
//		offset.transform.rotation.Set(30, 350,0,1);

		this.transform.rotation.Set (50, 350, 0, 1);

	}
	
	// Update is called once per frame
	void Update () {
	}
	void LateUpdate()
	{
		this.transform.position = offset + playerPos.transform.position;



	}
}
