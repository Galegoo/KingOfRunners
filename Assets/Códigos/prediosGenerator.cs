using UnityEngine;
using System.Collections;

public class prediosGenerator : MonoBehaviour {
	
	public Transform backGroundGenerator;
	public GameObject backGround;
	public Transform backGroundGenerationPoint;
	private float larguraDoBG = 17.5f;
	public ObjectPooler theObjectPooler;
	void Update () {
		
		if (transform.position.x < backGroundGenerationPoint.position.x) {
			
			transform.position = new Vector3 (transform.position.x + larguraDoBG, backGroundGenerationPoint.position.y,  transform.position.z);
			GameObject newpredio = theObjectPooler.GetPooledObject();
			newpredio.transform.position = transform.position;
			newpredio.transform.rotation = transform.rotation;
			newpredio.SetActive (true);
		}
	}
}