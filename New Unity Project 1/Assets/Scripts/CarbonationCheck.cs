using UnityEngine;
using System.Collections;

public class CarbonationCheck : MonoBehaviour
{
	float CarbonationLevel = 100.0f;
	float StiffLimitCarbonation = 75.0f;
	float FlatLimitCarbonation = 49.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			CarbonatonTest();
		
		CarbonationLevel -= Time.deltaTime * 4f;
	}
	
	
	void CarbonatonTest ()
	{
		// If the carbonation level is greater than StiffLimitCarbonation
		if(CarbonationLevel > StiffLimitCarbonation)
		{
			// ... do this.
			print("Soda is too stiff.");
		}
		// If The soda is not too stiff but below FlatLimitCarbonation
		else if(CarbonationLevel < FlatLimitCarbonation)
		{
			// ... do this.
			print("Soda is too flat.");
		}
		// If it's inbetween the Stiff level and Flat level
		else
		{
			// ... do this.
			print("Soda is good. <(^0^)>");
		}
	}
}