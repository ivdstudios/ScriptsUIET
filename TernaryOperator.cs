using UnityEngine;
using System.Collections;

public class TernaryOperator : MonoBehaviour {

	void Start () {
		int x = (3 > 5) ? 2 : 4; 
		print(x);
	}
}
