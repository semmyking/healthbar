using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    //variabelen
    public float TotalHp;
    public float CurrentHp;


	void Start ()
	{
	    CurrentHp = TotalHp;
	}
	
	void Update () {

	    if (Input.GetMouseButtonDown(0))
	    {
	        if (CurrentHp > 0)
	        {
	            TakeDamage();
	        }
	        else
	        {
	            print("Dead");
	        }
	    }

    }
    // scale van healtbar ( x as veranderen )
    void TakeDamage()
    {
        CurrentHp -= 5;
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
    }

    
    
    
}
