using UnityEngine;
using System.Collections;

public class fade : MonoBehaviour {
	public bool control = true;

	public Texture2D texture;
	public float alpha = 1;
	public float offset = 1;
	public	Color color;
	private Color tmp_color;
	// Use this for initialization
	void  Awake() {
		texture = new Texture2D( 1, 1, TextureFormat.ARGB32,false);
		texture.SetPixel(0,0,color);
		texture.Apply();
		tmp_color = new Color (color.r, color.g, color.b, alpha);
	}
	
	// Update is called once per frame
	void Update () {
		if(control){
			if(alpha >= 0){
				alpha -= Time.deltaTime*offset;
			}
			tmp_color = new Color (color.r, color.g, color.b, alpha);
		}
	}

	void OnGUI()
	{
		GUI.color = tmp_color;
		GUI.DrawTexture(new Rect( 0, 0, Screen.width, Screen.height ), texture );
	}
}
