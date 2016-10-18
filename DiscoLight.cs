using UnityEngine;
using System.Collections;

public class DiscoLight : MonoBehaviour {

	Color[] colors = { Color.red, Color.blue, Color.yellow};

	Light discoLight; 

	// Use this for initialization
	void Start () {
		discoLight = GetComponent<Light>(); 
		print(discoLight);
	}
	
	// Update is called once per frame
	void Update () {
		int variableRandom = Random.Range(0, 3); 
		int newVar = Random.Range(0, 9); 
		discoLight.color = colors[variableRandom];
		discoLight.intensity = newVar; 
	}
}


