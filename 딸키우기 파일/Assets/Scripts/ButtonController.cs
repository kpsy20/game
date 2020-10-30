using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// 버튼들 처리(메뉴로 들어가는 버튼)
/// </summary>
public class ButtonController : MonoBehaviour {
    public static int index;
    public static int temp;
    public static int limit = 0; //해상도 문제 발생 막기
    public Image index1;
    public Image index2;
    public Image index3;
    public Image index4;
    public Image index5;
    public Image index6;
    public Image index7;
    public Image index8;
    public Image cancel;
    private Vector3 turn_90 = new Vector3 (-90, 0, 0);
    private Vector3 turn90 = new Vector3 (90, 0, 0);
    public DataController dataController;
    
    public void StaminaGUI()
    {
        if (limit == 0)
        {
            index = 1;
            index1.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
        
    }
    public void HomeShoppingGUI()
    {
        if (limit == 0)
        {
            index = 2;
            index2.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void AcademyGUI()
    {
        if(limit == 0)
        {
            index = 3;
            index3.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void ResumeGUI()
    {
        if(limit == 0)
        {
            index = 4;
            index4.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void SubjobUpgradeGUI()
    {
        if(limit == 0)
        {
            index = 5;
            index5.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void ItemGUI()
    {
        if(limit == 0)
        {
            index = 6;
            index6.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void Detail()
    {
        if(limit==0)
        {
            index = 7;
            index7.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void MoveHouse()
    {
        if (limit == 0)
        {
            index = 8;
            index8.transform.Rotate(turn_90);
            limit = 1;
            cancel.transform.Rotate(turn_90);
        }
    }
    public void Cancel()
    {
        int temp = index;
        if (temp == 1)
        {
            index1.transform.Rotate(turn90);
        }
        if (temp == 2)
        {
            index2.transform.Rotate(turn90);
        }
        if (temp == 3)
        {
            index3.transform.Rotate(turn90);
        }
        if (temp == 4)
        {
            index4.transform.Rotate(turn90);
        }
        if (temp == 5)
        {
            index5.transform.Rotate(turn90);
        }
        if (temp == 6)
        {
            index6.transform.Rotate(turn90);
        }
        if(temp==7)
        {
            index7.transform.Rotate(turn90);    
        }
        if (temp == 8)
        {
            index8.transform.Rotate(turn90);
        }
        cancel.transform.Rotate(turn90);
        index = 0;
        temp = 0;
        limit = 0;
    }

    public void MainGUI()
    {
        int temp = index;
        if(temp == 1)
        {
            index3.transform.Rotate(turn90);
        }
        if(temp==2)
        {
            index4.transform.Rotate(turn90);
        }
        index = 0;
        temp = 0;
        limit = 0;
        
    }
}
