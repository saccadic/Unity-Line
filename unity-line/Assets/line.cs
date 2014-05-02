using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(LineRenderer))]
public class line : MonoBehaviour {

	public float wait_time;

	public int max;

	public int number;
	public GameObject obj;

	public float line_width = 1.0f;
	//public Vector3[] pos;
	private LineRenderer line_obj = null;
	public Material mate = null;

	private GameObject[] clone;
	void Start ()
	{
		clone = new GameObject[number];
		for(int i = 0; i < clone.Length; i++){
			clone[i] = (GameObject)GameObject.Instantiate(obj);
			clone[i].transform.position = new Vector3(Random.Range (-max, max),Random.Range(-max, max),Random.Range(-max, max));

			//change = new Color(Random.value, Random.value, Random.value, 1.0f);
			//clone[i].renderer.material.color = change;
			clone[i].transform.parent = transform;
			//clone[i].renderer.material = mate[(int)Random.Range (0f, mate.Length)];
		}

		line_obj = gameObject.GetComponent<LineRenderer>();
		line_obj.material = mate;
		line_obj.SetVertexCount (clone.Length);
		line_obj.useWorldSpace = false;
		line_obj.SetWidth(line_width ,line_width);

		//StartCoroutine("wait");
	}

	public Color change;
	void Update(){
	
		for(int i=0;i<clone.Length;i++){
			line_obj.SetPosition(i,clone[i].transform.position);
			//change = new Color(Random.value, Random.value, Random.value, 1.0f);
			//clone[i].renderer.material.color = change;
		}

	}

	int j=0;
	private IEnumerator wait() {
		//gameObject.transform.position -= tmp;
		if(j>clone.Length){
			j=0;
		}
		change = new Color(Random.value, Random.value, Random.value, 1.0f);
		clone[j].renderer.material.color = change;
		j++;
		yield return new WaitForSeconds(wait_time);
		//gameObject.transform.position += tmp;
		
		
		StartCoroutine("wait");
	}
}
