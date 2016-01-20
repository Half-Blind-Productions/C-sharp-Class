using UnityEngine;
using System.Collections;

public class VarandFuncPublic : MonoBehaviour 
{
	public int myInt = 0;
	
	// Use this for initialization
	void Start () 
	{

		
	}
	// Update is called once per frame
	void Update () 
	{
		myInt = AddOne (myInt);
		Debug.Log (myInt); 
	}
	
	int AddOne (int number)
	{
		int ret;
		ret = number + 1;
		return ret;	
	}
}
