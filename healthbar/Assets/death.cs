using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class death : MonoBehaviour
{
    public int health;
    public Text healthBar;

	// Use this for initialization
	private void Start()
	{
	    health = 10;
	}

    public void minHealth()
    {
        health--;
        print("lol");
        switch (health)
        {
            case 10:
                 healthBar.text = "Health: 0000000000";
                 break;
            case 9:
                 healthBar.text = "Health: 000000000";
                 break;
            case 8:
                 healthBar.text = "Health: 00000000";
                 break;
            case 7:
                 healthBar.text = "Health: 0000000";
                 break;
            case 6:
                 healthBar.text = "Health: 000000";
                 break;
            case 5:
                 healthBar.text = "Health: 00000";
                 break;
            case 4:
                 healthBar.text = "Health: 0000";
                 break;
            case 3:
                 healthBar.text = "Health: 000";
                 break;
            case 2:
                 healthBar.text = "Health: 00";
                 break;
            case 1:
                 healthBar.text = "Health: 0";
                 break;
            case 0: 
                 healthBar.text = "Health: RIP";
                 break;

        }
    }
}
