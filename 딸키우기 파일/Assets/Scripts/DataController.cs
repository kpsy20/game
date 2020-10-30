using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 각종 데이터 저장, 입력
/// 1초 지날때 처리
/// </summary>
public class DataController : MonoBehaviour {
    public static float s_gold;
    public static float s_goldPerClick;
    public static float s_goldPerSec;
    public static float s_smart;
    public static float s_stamina;
    public static float s_smartPerSec;
    public static float s_staminaPerSec;
    public static float s_usePerSec;
    public static float s_smartPercent;

    public static int forMain = 0;
    
    public InputField food1Input;
    public static int food1InputAmount;
    public static int food1Price;
    public static int food1RealAmount;

    public InputField food2Input;
    public static int food2InputAmount;
    public static int food2Price;
    public static int food2RealAmount;

    public static int furniture1Price;
    public static float furniture1Effect;
    public static int furniture1Done;
    public static float furniture1Permanent;
    
    public static int furniture2Price;
    public static float furniture2Effect;
    public static int furniture2Done;
    public static float furniture2Permanent;

    public static int furniture3Price;
    public static float furniture3Effect;
    public static int furniture3Done;
    public static float furniture3Permanent;

    public static int furniture4Price;
    public static float furniture4Effect;
    public static int furniture4Done;
    public static float furniture4Permanent;

    public static int furniture5Price;
    public static float furniture5Effect;
    public static int furniture5Done;
    public static float furniture5Permanent;

    public static int furniture6Price;
    public static float furniture6Effect;
    public static int furniture6Done;
    public static float furniture6Permanent;

    public static int furniture7Price;
    public static float furniture7Effect;
    public static int furniture7Done;
    public static float furniture7Permanent;

    public static float maxStamina;
    public static float smartPerStamina;

    public static float academy1Price;
    public static float academy1EffectPercent;
    public static float academy1EffectNumber;
    public static int academy1Level;
    public static float academy1Pow;
    public static float academy1SideEffect;
    public static float academy1UsePerSec;

    public static float job1Earn;
    public static string job1Name;
    public static float job1Percent;
    public static float job1Price;
    public static float job1Level;

    public static float house1Price;
    public static float house1UsePerSec;
    public static float house1SmartEffect;
    public static float house1StaminaEffect;
    public static float house1Done;
    public static float house1FurnitureDone;

    //0215

    public static float subjobLevel;
    public static float subjobUpgrade;
    public static float subjobTerm;
    public static float subjobDuring;
    public static float subjobTermStatic;
    /*
    public List<string> staminaRefillList = new List<string>();
    public List<string> homeShoppingList = new List<string>();
    public List<string> academyList = new List<string>();
    public List<string> resumeList = new List<string>();
    public List<string> subjobUpgradeList = new List<string>();
    public List<string> itemList = new List<string>();
    */

    public Text food1InputAmountCostText;
    public Text food2InputAmountCostText;

    private static DataController instance;
    private float temptime;
    private int time;
    public static int year = 2018;
    public static int month = 1;
    public static int day = 1;
    public static int age;
    public Text timetext;
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        Main.go = false;
       
    }
    public static DataController GetInstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<DataController>();
            if(instance == null)
            {
                GameObject container = new GameObject("DataController");
                instance = container.AddComponent<DataController>();
            }
        }
        return instance;
    }

    void Awake() 
    {
        s_gold = PlayerPrefs.GetFloat("gold", 3000000f);
        s_goldPerClick = PlayerPrefs.GetFloat("goldPerClick", 3000f);
        s_goldPerSec = PlayerPrefs.GetFloat("goldPerSec", 1500000f);
        s_smart = PlayerPrefs.GetFloat("smart", 10.0f);
        s_stamina = PlayerPrefs.GetFloat("stamina", 100.00f);
        s_smartPerSec = PlayerPrefs.GetFloat("smartPerSec", 0.1f);
        s_staminaPerSec = PlayerPrefs.GetFloat("staminaPerSec", 0.3f);
        s_usePerSec = PlayerPrefs.GetFloat("usePerSec", 30000f);
        s_smartPercent = PlayerPrefs.GetFloat("smartPercent", 0f);

        food1Price = PlayerPrefs.GetInt("food1Price", 10000);
        food1RealAmount = PlayerPrefs.GetInt("food1RealAmount", 30);

        food2Price = PlayerPrefs.GetInt("food2Price", 2000);
        food2RealAmount = PlayerPrefs.GetInt("food2RealAmount", 60);

        furniture1Done = PlayerPrefs.GetInt("furniture1Done", 0);
        furniture1Effect = PlayerPrefs.GetFloat("furniture1Effect", 0.05f);
        furniture1Price = PlayerPrefs.GetInt("furniture1Price", 400000);
        furniture1Permanent = PlayerPrefs.GetFloat("furniture1Permanent", 5f);

        furniture2Done = PlayerPrefs.GetInt("furniture2Done", 0);
        furniture2Effect = PlayerPrefs.GetFloat("furniture2Effect", 0.08f);
        furniture2Price = PlayerPrefs.GetInt("furniture2Price", 600000);
        furniture2Permanent = PlayerPrefs.GetFloat("furniture2Permanent", 10f);

        furniture3Done = PlayerPrefs.GetInt("furniture3Done", 0);
        furniture3Effect = PlayerPrefs.GetFloat("furniture3Effect", 0.105f);
        furniture3Price = PlayerPrefs.GetInt("furniture3Price", 800000);
        furniture3Permanent = PlayerPrefs.GetFloat("furniture3Permanent", 0f);

        furniture4Done = PlayerPrefs.GetInt("furniture4Done", 0);
        furniture4Effect = PlayerPrefs.GetFloat("furniture4Effect", 0.165f);
        furniture4Price = PlayerPrefs.GetInt("furniture4Price", 1200000);
        furniture4Permanent = PlayerPrefs.GetFloat("furniture4Permanent", 15f);

        furniture5Done = PlayerPrefs.GetInt("furniture5Done", 0);
        furniture5Effect = PlayerPrefs.GetFloat("furniture5Effect", 0.230f);
        furniture5Price = PlayerPrefs.GetInt("furniture5Price", 1600000);
        furniture5Permanent = PlayerPrefs.GetFloat("furniture5Permanent", 0f);

        furniture6Done = PlayerPrefs.GetInt("furniture6Done", 0);
        furniture6Effect = PlayerPrefs.GetFloat("furniture6Effect", 0.265f);
        furniture6Price = PlayerPrefs.GetInt("furniture6Price", 1800000);
        furniture6Permanent = PlayerPrefs.GetFloat("furniture6Permanent", 20f);

        furniture7Done = PlayerPrefs.GetInt("furniture7Done", 0);
        furniture7Effect = PlayerPrefs.GetFloat("furniture7Effect", 0.300f);
        furniture7Price = PlayerPrefs.GetInt("furniture7 Price", 2000000);
        furniture7Permanent = PlayerPrefs.GetFloat("furniture7Permanent", 25f);

        /// 0129
        
        maxStamina = PlayerPrefs.GetFloat("maxStamina", 100f);
        smartPerStamina = PlayerPrefs.GetFloat("smartPerStamina", 1f);

        academy1Price = PlayerPrefs.GetFloat("academy1Price", 200000f);
        academy1EffectPercent = PlayerPrefs.GetFloat("academy1EffectPercent", 0f);
        academy1EffectNumber = PlayerPrefs.GetFloat("academy1EffectNumber", 0f);
        academy1SideEffect = PlayerPrefs.GetFloat("academy1SideEffect", 0f);
        academy1Level = PlayerPrefs.GetInt("academy1Level", 0);
        academy1Pow = PlayerPrefs.GetFloat("academy1Pow", 0f);
        academy1UsePerSec = PlayerPrefs.GetFloat("academy1UsePerSec", 0f);
        

        year = PlayerPrefs.GetInt("year", 2018);
        month = PlayerPrefs.GetInt("month", 1);
        day = PlayerPrefs.GetInt("day", 1);
        age = PlayerPrefs.GetInt("age", 1);

        // 0205

        job1Earn = PlayerPrefs.GetFloat("job1Earn", 1500000f);
        job1Name = PlayerPrefs.GetString("job1Name", "인턴");
        job1Percent = PlayerPrefs.GetFloat("job1Percent", 100f);
        job1Price = PlayerPrefs.GetFloat("job1Price", 1500000f);
        job1Level = PlayerPrefs.GetFloat("job1Level", 1f);

        house1Price = PlayerPrefs.GetFloat("house1Price", 50000000f);
        house1UsePerSec = PlayerPrefs.GetFloat("house1UsePerSec", 50000f);
        house1SmartEffect = PlayerPrefs.GetFloat("house1SmartEffect", 20f); // %
        house1StaminaEffect = PlayerPrefs.GetFloat("house1StaminaEffect", 100f); // maxstamina
        house1Done = PlayerPrefs.GetFloat("house1Done", 0f);
        house1FurnitureDone = PlayerPrefs.GetFloat("house1FurnitureDone", 0f);
        //0215
        subjobLevel = PlayerPrefs.GetFloat("subjobLevel", 1f); //레벨
        subjobTerm = PlayerPrefs.GetFloat("subjobTerm", 100f); //기간
        subjobUpgrade = PlayerPrefs.GetFloat("subjobUpgrade", 10f); //체력감소
        subjobDuring = PlayerPrefs.GetFloat("subjobDuring", 0f);
        subjobTermStatic = PlayerPrefs.GetFloat("subjobTermStatic", 100f);
        //////

        SetF("gold", s_gold);
        SetF("goldPerClick", s_goldPerClick);
        SetF("goldPerSec", s_goldPerSec);
        SetF("smart", s_smart);
        SetF("stamina", s_stamina);
        SetF("smartPerSec", s_smartPerSec);
        SetF("staminaPerSec", s_staminaPerSec);
        SetF("usePerSec", s_usePerSec);
        SetF("smartPercent", s_smartPercent);

        SetI("food1RealAmount", food1RealAmount);
        SetI("food1Price", food1Price);
        SetI("food2RealAmount", food2RealAmount);
        SetI("food2Price", food2Price);

        SetI("year", year);
        SetI("month", month);
        SetI("day", day);
        SetI("age", age);

        SetI("furniture1Done", furniture1Done);
        SetF("furniture1Effect", furniture1Effect);
        SetI("furniture1Price", furniture1Price);
        SetF("furniture1Permanent", furniture1Permanent);

        SetI("furniture2Done", furniture2Done);
        SetF("furniture2Effect", furniture2Effect);
        SetI("furniture2Price", furniture2Price);
        SetF("furniture2Permanent", furniture2Permanent);

        SetI("furniture3Done", furniture3Done);
        SetF("furniture3Effect", furniture3Effect);
        SetI("furniture3Price", furniture3Price);
        SetF("furniture3Permanent", furniture3Permanent);

        SetI("furniture4Done", furniture4Done);
        SetF("furniture4Effect", furniture4Effect);
        SetI("furniture4Price", furniture4Price);
        SetF("furniture4Permanent", furniture4Permanent);

        SetI("furniture5Done", furniture5Done);
        SetF("furniture5Effect", furniture5Effect);
        SetI("furniture5Price", furniture5Price);
        SetF("furniture5Permanent", furniture5Permanent);

        SetI("furniture6Done", furniture6Done);
        SetF("furniture6Effect", furniture6Effect);
        SetI("furniture6Price", furniture6Price);
        SetF("furniture6Permanent", furniture6Permanent);

        SetI("furniture7Done", furniture7Done);
        SetF("furniture7Effect", furniture7Effect);
        SetI("furniture7Price", furniture7Price);
        SetF("furniture7Permanent", furniture7Permanent);

        SetF("maxStamina", maxStamina);
        SetF("smartPerStamina", smartPerStamina);

        SetF("academy1Price", academy1Price);
        SetF("academy1EffectPercent", academy1EffectPercent);
        SetF("academy1EffectNumber", academy1EffectNumber);
        SetF("academy1SideEffect", academy1SideEffect);
        SetI("academy1Level", academy1Level);
        SetF("academy1Pow", academy1Pow);
        SetF("academy1UsePerSec", academy1UsePerSec);

        SetF("job1Earn", job1Earn);
        SetF("job1Percent", job1Percent);
        SetS("job1Name", job1Name);
        SetF("job1Price", job1Price);
        SetF("job1Level", job1Level);

        SetF("house1Price", house1Price);
        SetF("house1UsePerSec", house1UsePerSec);
        SetF("house1SmartEffect", house1SmartEffect);
        SetF("house1StaminaEffect", house1StaminaEffect);
        SetF("house1Done", house1Done);
        SetF("house1FurnitureDone", house1FurnitureDone);

        SetF("subjobLevel", subjobLevel);
        SetF("subjobUpgrade", subjobUpgrade);
        SetF("subjobTerm", subjobTerm);
        SetF("subjobDuring", subjobDuring);
        SetF("subjobTermStatic", subjobTermStatic);
    }
    public void SetF(string name, float amount)
    {
        PlayerPrefs.SetFloat(name, amount);   
    }
    public void SetI(string name, int amount) // 아이템 레벨업
    {
        PlayerPrefs.SetInt(name, amount);
    }
    public void SetS(string name, string amount)
    {
        PlayerPrefs.SetString(name, amount);
    }
    public float GetF(string name)
    {
        return PlayerPrefs.GetFloat(name);
    }
    public int GetI(string name)
    {
        return PlayerPrefs.GetInt(name);
    }
	public void AddGold(float newgold)
    {
        s_gold += newgold;
        SetF("gold", s_gold);
    }
    public void SubGold(float newgold)
    {
        s_gold -= newgold;
        SetF("gold", s_gold);
    }
    public void AddStamina(float newstamina)
    {
        s_stamina += newstamina;
        SetF("stamina", s_stamina);
    }
    public void SubStamina(float newstamina)
    {
        s_stamina -= newstamina;
        SetF("stamina", s_stamina);
    }
    public void AddSmart(float newsmart)
    {
        s_smart += newsmart;
        SetF("smart", s_smart);
    }
    
    public void MinusStaminaPerSec(float n)
    {
        s_staminaPerSec -= n;
        SetF("staminaPerSec", s_staminaPerSec);
    }
    public void PlusSmartPerSec(float n)
    {
        s_smartPerSec += n;
        SetF("smartPerSec", s_smartPerSec);
    }
    public int GetTime()
    {
        return time;
    }
    private void FixedUpdate()
    {
        if (Main.go)
        {
            temptime = temptime + Time.deltaTime;
            time = (int)temptime; //에러 잡기
            if (time > 1)
            {
                time = 0;
            }
            if (time == 1) //1초는 여기
            {
                if(subjobDuring == 1)
                {
                    subjobTerm -= 1f;
                    SetF("subjobTerm", subjobTerm);
                    if(subjobTerm == 0f)
                    {
                        subjobDuring = 0f;
                        SetF("subjobLevel", subjobLevel + 1f);
                        subjobLevel = GetF("subjobLevel");
                        SetF("goldPerClick", s_goldPerClick * 2f);
                        s_goldPerClick = GetF("goldPerClick");
                        subjobTerm = subjobTermStatic + 100f;
                        SetF("subjobTerm", subjobTerm);
                        subjobTermStatic = GetF("subjobTerm");
                        SetF("subjobStatic", subjobTermStatic);
                    }
                }
                if (forMain == 0)
                {
                    forMain = 1;
                }
                else
                {
                    forMain = 0;
                }
                SubGold(GetF("usePerSec"));

                smartPerStamina = s_stamina / maxStamina;
                SetF("smartPerStamina", smartPerStamina);

                AddSmart(GetF("smartPerSec")* (1f + s_smartPercent/100) * smartPerStamina); //체력에 따른 지능 상승비율. + 보너스 상승 (smartPercent)
                if(s_gold < 0)
                {
                    SubStamina(GetF("staminaPerSec"));
                }
                day = day + 1;
                if(age < 4)
                {
                    if(food1RealAmount > 0)
                    {
                        SetI("food1RealAmount", GetI("food1RealAmount") - 1);
                        food1RealAmount = GetI("food1RealAmount");
                    }
                    else
                    {
                        SubStamina(GetF("staminaPerSec"));
                    }
                    if(food2RealAmount > 0)
                    {
                        if (food2RealAmount == 1)
                        {
                            SetI("food2RealAmount", GetI("food2RealAmount") - 1);
                            food2RealAmount = GetI("food2RealAmount");
                        }
                        else
                        {
                            SetI("food2RealAmount", GetI("food2RealAmount") - 2);
                            food2RealAmount = GetI("food2RealAmount");
                        }
                    }
                    else
                    {
                        SubStamina(GetF("staminaPerSec"));
                    }
                    
                    //SubStamina(GetF("staminaPerSec"));
                }
                time = 0;
                temptime = 0;
                SetI("day", day);
            }

            if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day == 32)
            {
                month = month + 1;
                day = 1;
                AddGold(GetF("goldPerSec"));
                SetI("month", month);
            }
            if ((month == 4 || month == 6 || month == 9 || month == 11) && day == 31)
            {
                month = month + 1;
                day = 1;
                AddGold(GetF("goldPerSec"));
                SetI("month", month);
            }
            if (month == 2 && day == 29)
            {
                month = month + 1;
                day = 1;
                AddGold(GetF("goldPerSec"));
                SetI("month", month);
            }

            if (month == 13)
            {
                year += 1;
                month = 1;
                age += 1;
                SetI("age", age);
                SetI("year", year);

            }
            timetext.text = year.ToString() + "년 " + month.ToString() + "월 " + day.ToString() + "일" + " 나이" + age.ToString();
            if (food1InputAmount > 0)
            {
                food1InputAmountCostText.text = (food1InputAmount * food1Price).ToString() + "원";
                if(s_gold > food1InputAmount * food1Price)
                {
                    Color newcolor = new Color(255, 255, 255);
                    food1InputAmountCostText.color = newcolor;
                    food1InputAmountCostText.text += " 구매 가능";
                }
                else
                {
                    Color newcolor = new Color(255, 0, 0);
                    food1InputAmountCostText.color = newcolor;
                    food1InputAmountCostText.text += "구매 불가";
                }
            }
            else
            {
                food1InputAmountCostText.text = "";
            }

            if(food2InputAmount>0)
            {
                food2InputAmountCostText.text = (food2InputAmount * food2Price).ToString() + "원";
                if (s_gold > food2InputAmount * food2Price)
                {
                    Color newcolor = new Color(255, 255, 255);
                    food2InputAmountCostText.color = newcolor;
                    food2InputAmountCostText.text += " 구매 가능";
                }
                else
                {
                    Color newcolor = new Color(255, 0, 0);
                    food2InputAmountCostText.color = newcolor;
                    food2InputAmountCostText.text += "구매 불가";
                }
            }
            else
            {
                food2InputAmountCostText.text = "";
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        int n1 = food1Input.text.Length;
        int n2 = food2Input.text.Length;
        if (n1 == 0)
        {
            food1InputAmount = 0;
        }
        if (n1 > 0)
        {
            try
            {
                food1InputAmount = int.Parse(food1Input.text);
            }
            catch (Exception e)
            {
                Debug.Log("다시 입력해 주세요");
                food1Input.text = "";
            }
        }

        if (n2 == 0)
        {
            food2InputAmount = 0;
        }
        if (n2 > 0)
        {
            try
            {
                food2InputAmount = int.Parse(food2Input.text);
            }
            catch (Exception e)
            {
                Debug.Log("다시 입력해 주세요");
                food2Input.text = "";
            }
        }
    }
}
