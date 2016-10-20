using UnityEngine;
using System.Collections;

public class DiscoLight : MonoBehaviour {

	Color[] colors = { Color.red, Color.blue, Color.yellow};

	Light discoLight; 

	string s = "2"; 

	// Use this for initialization
	void Start () {
		int jordon = int.Parse(s); 
		string newString = jordon.ToString(); 

		bool val = System.Convert.ToBoolean("True"); 

		if(val == true)
		{
			print("Maja aavigayoo");
		}

		print("This is string" + newString); 

		print("Printing is fun...you may print it " + jordon); 
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


