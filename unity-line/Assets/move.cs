using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public float n;
	public float max;

	public float offset;

	public bool l = true;
	// Use this for initialization

	public bool trigger = false;
	void Start () {
		StartCoroutine("wait");
	}

	void Update(){


		if(l){
			gameObject.transform.position += tmp * offset;
		}else{
			gameObject.transform.position -= tmp * offset;
		}
	}

	private Vector3 tmp = Vector3.zero;
	private IEnumerator wait() {
		tmp = new Vector3 (Random.Range (-max, max),Random.Range (-max, max),Random.Range (-max, max));
		if(l){
			l = false;
		}else{
			l = true;
		}
		trigger = false;
		//gameObject.transform.position -= tmp;
		yield return new WaitForSeconds(n);
		//gameObject.transform.position += tmp;


		StartCoroutine("wait");
	}

	private void OnTriggerEnter(Collider other)
	{
		trigger = true;
	}
	
	private void OnTriggerStay(Collider other)
	{

	}
	
	private void OnTriggerExit(Collider other)
	{
		//trigger = true;
	}
}
