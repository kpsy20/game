using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 텍스트 처리
/// 이미지 처리
/// </summary>
public class Main : MonoBehaviour {
    public DataController dataController;
    public Text goldText;
    public Text goldPerSecText;
    public Text goldPerClickText;
    public Text smartText;
    public Text staminaText;
    public Text usePerSecText;
    public Text smartPerStamina;
    public Text food1Amount;
    public Text food2Amount;

    public Text furniture1Done;
    public Text furniture2Done;
    public Text furniture3Done;
    public Text furniture4Done;
    public Text furniture5Done;
    public Text furniture6Done;
    public Text furniture7Done;
    //가구 버튼
    public Image fur1;
    public Image fur2;
    public Image fur3;
    public Image fur4;
    public Image fur5;
    public Image fur6;
    public Image fur7;

    public Image main1;
    public Image main2;

    public Text academy1BeforeText;
    public Text academy1AfterText;
    public Text academy1PriceText;

    public Text job1BeforeText;
    public Text job1AfterText;
    public Text job1Probability;
    public Text job1PriceText;
    public Text job1InformationText;

    public Text detail1;
    public Text detail2;

    public Text moveHouseText;
    public Text moveHouseButtonText;

    public Text subjob1Text;
    public Text subjob2Text;
    public Text subjob3Text;
    private string subjobName;
    
    public static bool go = true;
    private string job;
    

    private void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1440, 2560, true);
       
    }
    // Update is called once per frame
    void Update () {
        if (DataController.job1Name == "인턴")
        {
            if (DataController.job1Level == 10)
            {
                job = "사원";
            }
            else
            {
                job = "인턴";
            }
        }
        if (DataController.job1Name == "사원")
        {
            if (DataController.job1Level == 10)
            {
                job = "대리";
            }
            else
            {
                job = "사원";
            }
        }
        if (DataController.job1Name == "대리")
        {
            if (DataController.job1Level == 10)
            {
                job = "과장";
            }
            else
            {
                job = "대리";
            }
        }
        if (DataController.job1Name == "과장")
        {
            if (DataController.job1Level == 10)
            {
                job = "차장";
            }
            else
            {
                job = "과장";
            }
        }
        if (DataController.job1Name == "차장")
        {
            if (DataController.job1Level == 10)
            {
                job = "부장";
            }
            else
            {
                job = "차장";
            }
        }
        if (DataController.job1Name == "부장")
        {
            if (DataController.job1Level == 10)
            {
                job = "이사";
            }
            else
            {
                job = "부장";
            }
        }
        if (DataController.job1Name == "이사")
        {
            if (DataController.job1Level == 10)
            {
                job = "상무";
            }
            else
            {
                job = "이사";
            }
        }
        if (DataController.job1Name == "상무")
        {
            if (DataController.job1Level == 10)
            {
                job = "전무";
            }
            else
            {
                job = "상무";
            }
        }
        if (DataController.job1Name == "전무")
        {
            if (DataController.job1Level == 10)
            {
                job = "사장";
            }
            else
            {
                job = "전무";
            }
        }
        if (DataController.job1Name == "사장")
        {
            if (DataController.job1Level == 10)
            {
                job = "회장";
            }
            else
            {
                job = "사장";
            }
        }

        if(DataController.s_gold > 10000000000f)
        {
            goldText.fontSize = 40;
        }
        else
        {
            goldText.fontSize = 50;
        }

        if(DataController.s_goldPerSec > 10000000000f)
        {
            goldPerClickText.fontSize = 40;
        }
        else
        {
            goldPerSecText.fontSize = 50;
        }
        goldText.text = "현재 돈" + "\n" + string.Format("{0:#,###0}", dataController.GetF("gold")) +"원";
        goldPerSecText.text = "월급"+"\n" +"+"+ string.Format("{0:#,###0}", dataController.GetF("goldPerSec")) + "원";
        goldPerClickText.text = "부업 수입"+"\n" +"+"+ string.Format("{0:#,###0}", dataController.GetF("goldPerClick")) + "원";
        smartText.text = "지능"+"\n" + dataController.GetF("smart").ToString(".#");
        staminaText.text = "체력" +"\n"+ dataController.GetF("stamina").ToString(".##") + " / " + dataController.GetF("maxStamina").ToString("#.");
        usePerSecText.text = "생활비"+"\n" +"-"+ string.Format("{0:#,###0}", dataController.GetF("usePerSec")) + "원";

        food1Amount.text = "분유: " + DataController.food1RealAmount.ToString() + "개";
        food2Amount.text = "기저귀: " + DataController.food2RealAmount.ToString() + "개";

        academy1BeforeText.text = "현재 레벨: " + DataController.academy1Level.ToString()
                + "\n" + "초당 지능(%) +" + DataController.academy1EffectPercent.ToString() + "%" 
                + "\n" + "초당 지능 +" + DataController.academy1EffectNumber.ToString()
                + "\n" + "초당 체력 소모: " + DataController.academy1SideEffect.ToString() 
                + "\n" + "생활비 증가: " + string.Format("{0:#,###0}", DataController.academy1UsePerSec) +"원";

        academy1AfterText.text = "다음 레벨: " + (DataController.academy1Level + 1).ToString()
                + "\n" + "초당 지능(%) +" + (DataController.academy1EffectPercent + 1).ToString() + "%" 
                + "\n" + "초당 지능 +" + (DataController.academy1EffectNumber + 1).ToString()
                + "\n" + "초당 체력 소모: " + (DataController.academy1SideEffect + 0.3f).ToString()
                + "\n" + "생활비 증가: " + string.Format("{0:#,###0}", DataController.academy1UsePerSec+10000f) + "원";

        academy1PriceText.text = "업그레이드 가격: " + string.Format("{0:#,###0}", DataController.academy1Price) + "원";

        //DataController.subjobLevel
        //DataController.subjobTerm
        //DataController.subjobUpgrade
        if (DataController.subjobLevel == 1)
        {
            subjobName = "곰인형에 눈알 붙이기";
        }
        if (DataController.subjobLevel == 2)
        {
            subjobName = "큐빅 악세사리 만들기";
        }
        if (DataController.subjobLevel == 3)
        {
            subjobName = "3단계 부업";
        }
        if (DataController.subjobLevel == 4)
        {
            subjobName = "파워블로거 활동하기";
        }
        if (DataController.subjobLevel == 5)
        {
            subjobName = "주식투자 하기";
        }
        subjob1Text.text = "현재 부업" + "\n" + subjobName + "\n" + "현재 수입" + "\n" + "터치당 " + DataController.s_goldPerClick.ToString() + "원";
        subjob2Text.text = "다음 부업 수입" + "\n" + "터치당 " + (DataController.s_goldPerClick * 2f).ToString() + "원";
        subjob3Text.text = "업그레이드 소요 시간" + "\n" + DataController.subjobTerm.ToString() + "\n" + "체력 소모" + "\n" + DataController.subjobUpgrade.ToString();

        job1InformationText.text = "직위: " + DataController.job1Name + "\n" + "Lv " + DataController.job1Level.ToString();
        if (DataController.job1Name == "회장" && DataController.job1Level == 10)
        {
            job1BeforeText.text = "현재 버는 돈" + "\n" + string.Format("{0:#,###0}", DataController.job1Earn) + "원" + "\n" + "직위: " + DataController.job1Name;
            job1AfterText.text = "진급 완료";
            Color c = new Color(255, 0, 0);
            job1AfterText.color = c;
            job1Probability.text = "";
            job1PriceText.text = "";
        }
        else
        {
            job1BeforeText.text = "현재 버는 돈" + "\n" + string.Format("{0:#,###0}", DataController.job1Earn) + "원" + "\n" + "직위: " + DataController.job1Name 
                + "\n" + "Lv " + DataController.job1Level.ToString();
            job1AfterText.text = "레벨업당" + "\n" + "인턴 +10만원, " + "사원 +20만원" + "\n" + "대리 +30만원, " + "과장 +40만원"
                + "\n" + "차장 +50만원, " + "부장 +60만원" + "\n" + "이사 +70만원, " + "상무 +80만원" + "\n" + "전무 +90만원, " + "사장 +100만원"
                + "\n" + "회장 +110만원" + "\n" + "\n" + "최대 레벨은 10";
            job1Probability.text = "성공 확률: " + DataController.job1Percent.ToString() + "%";
            job1PriceText.text = "진급 비용: " + string.Format("{0:#,###0}", DataController.job1Price) + "원";
        }
        
        smartPerStamina.text = (dataController.GetF("smartPerStamina")*100).ToString(".##")+"%";

        detail1.text = "체력 100% 일 때 지능 상승 " + dataController.GetF("smartPerSec").ToString();
        detail2.text = "총 지출" + "\n" + "생활비 " + string.Format("{0:#,###0}", dataController.GetF("usePerSec") - DataController.academy1UsePerSec) +"원"
        +"\n" + "학원비 " + string.Format("{0:#,###0}", dataController.GetF("academy1UsePerSec")) + "원";

        moveHouseText.text = "이사 비용: " + string.Format("{0:#,###0}", dataController.GetF("house1Price")) + "원"
            + "\n";
        if (DataController.house1FurnitureDone != 7)
        {
            moveHouseButtonText.text = "가구를 모두 구입해 주세요";
        }
        else
        {
            moveHouseButtonText.text = "구매 가능";
        }

        if (DataController.furniture1Done == 0)
        {
            furniture1Done.text = "구매가능";
        }
        else if(DataController.furniture1Done == 1)
        {
            furniture1Done.text = "구매완료";
            fur1.enabled = true;
            //StartCoroutine("Fur_1");
        }

        if(DataController.furniture2Done == 0)
        {
            furniture2Done.text = "구매가능";
        }
        else if(DataController.furniture2Done == 1)
        {
            furniture2Done.text = "구매완료";
            fur2.enabled = true;
        }

      
        if (DataController.furniture3Done == 0)
        {
            furniture3Done.text = "구매가능";
        }
        else if (DataController.furniture3Done == 1)
        {
            furniture3Done.text = "구매완료";
            fur3.enabled = true;
        }

       
        if(DataController.furniture4Done == 0)
        {
            furniture4Done.text = "구매가능";
        }
        else if (DataController.furniture4Done == 1)
        {
            furniture4Done.text = "구매완료";
            fur4.enabled = true;
        }

        if(DataController.furniture5Done == 0)
        {
            furniture5Done.text = "구매가능";
        }
        else if (DataController.furniture5Done == 1)
        {
            furniture5Done.text = "구매완료";
            fur5.enabled = true;
        }

        if(DataController.furniture6Done == 0)
        {
            furniture6Done.text = "구매가능";
        }
        else if (DataController.furniture6Done == 1)
        {
            furniture6Done.text = "구매완료";
            fur6.enabled = true;
        }

        if(DataController.furniture7Done == 0)
        {
            furniture7Done.text = "구매가능";
        }
        else if (DataController.furniture7Done == 1)
        {
            furniture7Done.text = "구매완료";
            fur7.enabled = true;
        }

       

    }
    IEnumerator Fur_1()
    {
        Color startColor = fur1.color;
        startColor.a = 0f;
        for(int i=0; i<100; i++)
        {
            startColor.a = startColor.a + 0.02f;
            fur1.color = startColor;
            yield return new WaitForSeconds(0.01f);
        }
    }
    
}
