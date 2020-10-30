using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class First : MonoBehaviour {
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;

    public Text n;
    public Text b;
    public static int index;
    private void Start()
    {
        index = 1;
    }
    // Update is called once per frame
    void Update () {
		if(index == 1)
        {
            b.text = "첫 페이지 입니다";
            n.text = "터치해서 넘기기";
            text1.enabled = true;
            text2.enabled = false;
            text3.enabled = false;
            text4.enabled = false;
        }
        if(index == 2)
        {
            b.text = "이전 설명 다시보기";
            n.text = "터치해서 넘기기";
            text1.enabled = false;
            text2.enabled = true;
            text3.enabled = false;
            text4.enabled = false;
        }
        if(index == 3)
        {
            b.text = "이전 설명 다시보기";
            n.text = "터치해서 넘기기";
            text1.enabled = false;
            text2.enabled = false;
            text3.enabled = true;
            text4.enabled = false;
        }
        if(index == 4)
        {
            b.text = "이전 설명 다시보기";
            n.text = "게임 시작!";
            text1.enabled = false;
            text2.enabled = false;
            text3.enabled = false;
            text4.enabled = true;
        }
	}
}
