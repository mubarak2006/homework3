using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{
    string heroName = "mubarak";
    int heroPower = 30;
    string villainName = "mb";
    int villainPower = 60;
    float playerSpeed = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        //if (heroPower > villainPower)
        //{ 

    }
        //else if (heroPower < villainPower)
        //{
            
        //}
        //else
        //{

        }
    // Update is called once per frame
    void Update()
    {
        
    }
     ****** SetSpeed(float NewSpeed)
    {
            print("old speed is " + playerSpeed);
            playerSpeed = newSpeed;
            print("new speed is " + playerSpeed);
    }
}
