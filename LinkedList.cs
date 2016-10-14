using UnityEngine;
using System.Collections;

public class LinkedList : MonoBehaviour {


	public int ShahRukhKhanKeBache;

	public class LinkedFile{
		public int value; 
		public string nameOfFolder; 
		public LinkedFile parentFolder; 
		public LinkedFile childFolder; 

		public LinkedFile()
		{
			print("Contructor chala of Object bana or LinkedFile ka return hua"); 
		}

		public void renameFolder(string newNameFolder)
		{
			nameOfFolder = newNameFolder;  
		}
	}

	LinkedList[] hardDrive = new LinkedList[5]; 

	public LinkedFile root = new LinkedFile(); 
	public LinkedFile cF = new LinkedFile(); 

	public LinkedFile ccF = new LinkedFile(); 

	void Start(){

		ShahRukhKhanKeBache = 34; 
		root.nameOfFolder = "C Drive";
		root.value = 324234; 

		root.parentFolder = null; 
		root.childFolder = cF; 

		cF.nameOfFolder = "Program Files";


		print(root.childFolder.nameOfFolder); 

		ccF.nameOfFolder = "Study Material";
		cF.childFolder = ccF; 

		print(cF.childFolder.nameOfFolder);

		ccF.renameFolder("XXX"); 

		print(ccF.nameOfFolder);

		print("niche ek object ban raha hai or uska constuctor chalega"); 
		LinkedFile nayaObject = new LinkedFile(); 
	}
}
