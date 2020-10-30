using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player : MonoBehaviour {
    public float sensibility = 3.0f; //마우스 감도
    public Text x;
    public Text y;
    public Text z;
   
    public static float degree;
    void Start () {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensibility, 0);  //마우스 x축 회전
        Quaternion b = new Quaternion(0, 0, 0, 1);
        z.text = Quaternion.Angle(b, transform.rotation).ToString();
        if((transform.rotation.y < 0 && transform.rotation.w < 0) || (transform.rotation.y > 0 && transform.rotation.w > 0))
        {
            z.text = Quaternion.Angle(b, transform.rotation).ToString("#.");
            degree = Quaternion.Angle(b, transform.rotation);
        }
        else
        {
            z.text = (360 - Quaternion.Angle(b, transform.rotation)).ToString("#.");
            degree = 360 - Quaternion.Angle(b, transform.rotation);
        }
        
        if(Input.GetMouseButtonDown(0))
        {
            
            /// 0
            if(degree<15 || degree > 345)
            {
                if(SoundOn.vol1.myName == "0edge")
                {
                    y.text = "Correct direction!";
                }
                else
                {
                    y.text = "Failed..";
                }
            }
            /// 90
            else if (degree < 105 && degree > 75)
            {
                if(SoundOn.vol1.myName == "90edge")
                {
                    y.text = "Correct direction!";
                }
                else
                {
                    y.text = "Failed..";
                }
            }
            /// 180
            else if (degree < 195 && degree > 165)
            {
                if (SoundOn.vol1.myName == "180edge")
                {
                    y.text = "Correct direction!";
                }
                else
                {
                    y.text = "Failed..";
                }
            }
            ///270
            else if (degree < 285 && degree > 255)
            {
                if (SoundOn.vol1.myName == "270edge")
                {
                    y.text = "Correct direction!";
                }
                else
                {
                    y.text = "Failed..";
                }
            }
            else
            {
                y.text = "Failed..";
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            y.text = "ready";
        }
        
    }

}
