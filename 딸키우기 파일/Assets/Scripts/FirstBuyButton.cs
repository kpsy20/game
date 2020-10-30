using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FirstBuyButton : MonoBehaviour
{
    public void OnMouseDown()
    {
        Debug.Log(First.index);
        if (this.name == "Next")
        {
            if (First.index <= 4)
            {
                First.index++;
            }
            if (First.index == 5)
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (this.name == "Before")
        {
            if (First.index >= 1)
            {
                First.index--;
            }
        }
    }
}
