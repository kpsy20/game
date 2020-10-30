using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOn : MonoBehaviour {
	public bool musicOn;
    public static SoundOn vol1;
    public Text y;
    public string myName;
    public AudioSource[] musicArray;
    public static int rand;
    public int vole;
   
	// Use this for initialization
	void Start () {
        
	}
  
	// Update is called once per frame
	void Update () {
       
        if(Input.GetKeyDown(KeyCode.Space))
		{
            for (int i=0; i<musicArray.Length; i++)
            {
                musicArray[i].volume = 0;
                this.musicOn = false;
            }
            rand = Game.ran;
			musicArray[rand].volume=1;
            
            
            if (rand==0)
            {
               
                if (this.myName == "0edge")
                {
                    this.musicOn = true;
                    
                    vol1 = this;
                }
                else
                {
                    this.musicOn = false;
                    
                }
            }
            if (rand == 1)
            {
                if (this.myName == "90edge")
                {
                    this.musicOn = true;
                    vol1 = this;
                }
                else
                {
                    this.musicOn = false;
                }
            }
            if (rand == 2)
            {
                if (this.myName == "180edge")
                {
                    this.musicOn = true;
                    vol1 = this;
                }
                else
                {
                    this.musicOn = false;
                }
            }
            if (rand == 3)
            {
                if (this.myName == "270edge")
                {
                    this.musicOn = true;
                    vol1 = this;
                }
                else
                {
                    this.musicOn = false;
                }
            }
            
        }
        
	}
}
