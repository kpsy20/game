using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public static int ran;
    private int newone = -1;
   
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            
            ran = Random.Range(0, 4);
            while (newone == ran)
            {
                ran = Random.Range(0, 4);
            }
            newone = ran;
        }
	}

}
