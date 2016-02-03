using UnityEngine;
using System.Collections;

public class WhileLoops : MonoBehaviour
{
	int numFrames = 24;
	
	
	void Start ()
	{
		while(numFrames > 0)
		{
			Debug.Log ("Frame " + numFrames + " Has Been Rendered");
			numFrames--;
		}
	}
}