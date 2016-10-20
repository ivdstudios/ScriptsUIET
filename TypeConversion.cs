using UnityEngine;
using System.Collections;

public class TypeConversion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int i = 45; 
		string s = i.ToString(); 

		string ss = "45";

		string sssssssss = "342"; 
		int sss2 = System.Convert.ToInt16(ss); 
		int ssssss = System.Convert.ToInt16(sssssssss) ; 
	}

}
