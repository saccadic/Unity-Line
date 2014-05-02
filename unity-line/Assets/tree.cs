using UnityEngine;
using System.Collections;

public class tree : MonoBehaviour {
	public float offset = 0f;

	public int number;
	public GameObject obj;
	public float timer;

	public move move;

	private GameObject[] clone;

	// Use this for initialization
	void Start () {
		clone = new GameObject[number];
		for(int i = 0; i < clone.Length; i++){
			clone[i] = (GameObject)GameObject.Instantiate(obj);
			clone[i].transform.position = gameObject.transform.position;
			//change = new Color(Random.value, Random.value, Random.value, 1.0f);
			//clone[i].renderer.material.color = change;
			clone[i].transform.parent = transform;
			//clone[i].renderer.material = mate[(int)Random.Range (0f, mate.Length)];
		}

		StartCoroutine("wait");
	}
	
	// Update is called once per frame
	public int i;
	float angle = 0f;
	bool check = true;
	Vector3 tmp=Vector3.zero;
	public Vector3 tmp2=Vector3.zero;
	void Update () {
		if(i > clone.Length){
			i = 0;
		}


		tmp2 += tmp;
		clone[i++].transform.position = tmp2;
		//clone [i++].transform.localScale /= i * 0.1f;
		if(i % 100 == 0){
			tmp2 = Vector3.zero;
			tmp = Vector3.zero;
		}
	}

	int j;
	private Vector3 tmp_v;
	private IEnumerator wait() {
		//tmp_v += new Vector3(Random.value,Random.value,Random.value);
		//clone [j++].transform.position = tmp;

		switch(Random.Range (0, 3)){
		case 0:
			tmp = new Vector3(offset,0,0);
			break;
		case 1:
			tmp = new Vector3(0,offset,0);
			break;
		case 2:
			tmp = new Vector3(-offset,0,0);
			break;
		case 3:
			tmp = new Vector3(0,-offset,0);
			break;
		case 4:
			tmp = new Vector3(0,0,offset);
			break;
		case 5:
			tmp = new Vector3(0,0,-offset);
			break;
		}



		yield return new WaitForSeconds(timer);
		StartCoroutine("wait");
	}


}
