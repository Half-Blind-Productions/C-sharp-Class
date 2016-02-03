using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour 
{   
	void Start () 
	{
		string[] strings = new string[9];
		
		strings[0] = "Enie";
		strings[1] = "Meanie";
		strings[2] = "Minie";
		strings[3] = "Mo";
		strings[4] = "  ";
		strings[5] = "Catch a";
		strings[6] = "Tiger";
		strings[7] = "by the";
		strings[8] = "Toe";

		foreach(string item in strings)
		{
			print (item);
		}
	}
}