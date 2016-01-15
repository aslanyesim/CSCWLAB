using UnityEngine;
using System.Collections;

public class PrinterHeadAnimator : MonoBehaviour {
	public float min;
	public float max;


	// Use this for initialization
	void Start () {

		min=transform.position.y;
		max=transform.position.y+3;

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time*2,max-min)+min, transform.position.z);
		
	}
	
}