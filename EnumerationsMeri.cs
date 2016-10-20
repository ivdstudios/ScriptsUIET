using UnityEngine;
using System.Collections;

public class EnumerationsMeri : MonoBehaviour {

	enum Days{ Mon, Tue, Wed, Thrus, Fri, Sat, Sun}; 

	Days today; 


	// Use this for initialization
	void Start () {
		today = Days.Tue; 

		switch(today)
		{
		case Days.Mon:
			print("Today is Mon. We will eat Banana is break fast");
			break; 
		case Days.Tue:
			print("Today is Tue. Don't eat Non-Veg"); 
			break;
		default:
			print("I don't know what's the day today"); 
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
