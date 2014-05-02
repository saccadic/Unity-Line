using UnityEngine;
using System.Collections;

public class rotato : MonoBehaviour {

	public Vector3 r = Vector3.zero;
	public float min=0f;
	public float max=1f;
	public bool random = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(random) r = new Vector3(Random.Range(min, max+1),Random.Range(min, max+1),Random.Range(min, max+1));

		transform.Rotate(r);
	}
}
