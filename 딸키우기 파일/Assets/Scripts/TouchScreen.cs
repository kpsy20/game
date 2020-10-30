using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 터치스크린 처리
/// </summary>
public class TouchScreen : MonoBehaviour {
    public DataController dataController;
    private Touch touchTemp;
    /*
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            int i = Input.touchCount;
            for(;i>0;i--)
            {
                touchTemp = Input.GetTouch(i);
                if (touchTemp.phase == TouchPhase.Stationary)
                {
                    dataController.AddGold(dataController.GetF("goldPerClick"));
                }
            }
        }
    }
    */
    public void OnMouseDown()
    {
        if (this.name == "BackgroundImage") { dataController.AddGold(dataController.GetF("goldPerClick")); }
    }


}   
    
    /*void Update()
    {
        if(Input.touchCount > 0)
        {
            int i = Input.touchCount;
            for (; i > 0; i--)
            {
                tempTouchs = Input.GetTouch(i);
                if (tempTouchs.phase == TouchPhase.Began)
                {
                    dataController.AddGold(dataController.GetF("goldPerClick"));
                }
            }
            
        }*/
    /*
    private Touch tempTouchs;
    private Vector3 touchedPos;
    private bool touchOn;
    public void touch()
    {
        touchOn = false;

        if (Input.touchCount > 0)
        {    //터치가 1개 이상이면.
            for (int i = 0; i < Input.touchCount; i++)
            {
                tempTouchs = Input.GetTouch(i);
                if (tempTouchs.phase == TouchPhase.Began)
                {    //해당 터치가 시작됐다면.
                    touchedPos = Camera.main.ScreenToWorldPoint(tempTouchs.position);//get world position.
                    touchOn = true;

                    break;   //한 프레임(update)에는 하나만.
                }
            }
        }
    }*/

