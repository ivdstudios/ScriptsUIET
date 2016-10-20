using UnityEngine;
using System.Collections;

public class PassByReference : MonoBehaviour {


	void Start () {
		int boyAge = 20; 
		string boyName = "Nawal"; 

		int girlAge = 20; 
		string girlName = "Rupali Malik"; 

		BoyAge(ref boyAge,ref boyName);
		GirlAge(ref girlAge,ref girlName); 

		print("Boy current age: " + boyAge); 
		print("Girl current age: " + girlAge); 
	}

	void BoyAge(ref int age,ref string name)
	{
		age+=5; 
		print("After 5 years " + name + " has age = " + age); 
	}


	void GirlAge(ref int age,ref string name)
	{
		age+=1; 
		print("After 5 years " + name + " has age = " + age);
	}

}
