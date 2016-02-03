using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
	int Pienum = 4;
	
	
	void Start ()
	{
		for(int i = 1; i < Pienum; i++)
		{
			Debug.Log("Making Pie #: " + i);
		}
	}
}