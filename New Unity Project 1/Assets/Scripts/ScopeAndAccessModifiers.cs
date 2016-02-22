using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour
{
	public int alpha = 57;
	
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		alpha = 43;
	    beta = 0;
	    gamma = 5;
		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(alpha, myOtherClass.apples);
	}
	
	
	void Example (int pens, int crayons)
	{
		int answer;
		answer = pens * crayons * alpha;
		Debug.Log(answer);
	}
	
	
	void Update ()
	{
		Debug.Log("Alpha is set to: " + alpha);
	}
}