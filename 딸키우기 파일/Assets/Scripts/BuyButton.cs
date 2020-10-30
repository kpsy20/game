using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 물건 사는 버튼 처리
/// </summary>
public class BuyButton : MonoBehaviour
{
    public DataController dataController;
    
    public void OnMouseDown()
    {
        if(this.name == "food1BuyButton")
        {
            if (dataController.GetF("gold") > dataController.GetI("food1Price") * DataController.food1InputAmount)
            {
                dataController.SetI("food1RealAmount", dataController.GetI("food1RealAmount") + DataController.food1InputAmount);
                DataController.food1RealAmount = dataController.GetI("food1RealAmount");
                dataController.SubGold(DataController.food1InputAmount * dataController.GetI("food1Price"));
                DataController.food1InputAmount = 0;
            }
        }
        if(this.name == "food2BuyButton")
        {
            if (dataController.GetF("gold") > dataController.GetI("food2Price") * DataController.food2InputAmount)
            {
                dataController.SetI("food2RealAmount", dataController.GetI("food2RealAmount") + DataController.food2InputAmount);
                DataController.food2RealAmount = dataController.GetI("food2RealAmount");
                dataController.SubGold(DataController.food2InputAmount * dataController.GetI("food2Price"));
                DataController.food2InputAmount = 0;
            }
        }
        if(this.name == "furniture1BuyButton" && DataController.furniture1Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture1Price"))
            {
                dataController.SetI("furniture1Done", 1);
                DataController.furniture1Done = dataController.GetI("furniture1Done");
                dataController.SubGold(DataController.furniture1Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture1Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture1Permanent);
                dataController.AddStamina(DataController.furniture1Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
                
            }
            
        }
        if(this.name == "furniture2BuyButton" && DataController.furniture2Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture2Price"))
            {
                dataController.SetI("furniture2Done", 1);
                DataController.furniture2Done = dataController.GetI("furniture2Done");
                dataController.SubGold(DataController.furniture2Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture2Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture2Permanent);
                dataController.AddStamina(DataController.furniture2Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
            }
        }
        if(this.name == "furniture3BuyButton" && DataController.furniture3Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture3Price"))
            {
                dataController.SetI("furniture3Done", 1);
                DataController.furniture3Done = dataController.GetI("furniture3Done");
                dataController.SubGold(DataController.furniture3Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture3Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture3Permanent);
                dataController.AddStamina(DataController.furniture3Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
            }
        }
        if(this.name == "furniture4BuyButton" && DataController.furniture4Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture4Price"))
            {
                dataController.SetI("furniture4Done", 1);
                DataController.furniture4Done = dataController.GetI("furniture4Done");
                dataController.SubGold(DataController.furniture4Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture4Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture4Permanent);
                dataController.AddStamina(DataController.furniture4Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
            }
        }
        if(this.name == "furniture5BuyButton" && DataController.furniture5Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture5Price"))
            {
                dataController.SetI("furniture5Done", 1);
                DataController.furniture5Done = dataController.GetI("furniture5Done");
                dataController.SubGold(DataController.furniture5Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture5Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture5Permanent);
                dataController.AddStamina(DataController.furniture5Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
            }
        }
        if(this.name == "furniture6BuyButton" && DataController.furniture6Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture6Price"))
            {
                dataController.SetI("furniture6Done", 1);
                DataController.furniture6Done = dataController.GetI("furniture6Done");
                dataController.SubGold(DataController.furniture6Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture6Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture6Permanent);
                dataController.AddStamina(DataController.furniture6Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
            }
        }
        if(this.name == "furniture7BuyButton" && DataController.furniture7Done == 0)
        {
            if (dataController.GetF("gold") > dataController.GetI("furniture7Price"))
            {
                dataController.SetI("furniture7Done", 1);
                DataController.furniture7Done = dataController.GetI("furniture7Done");
                dataController.SubGold(DataController.furniture7Price);
                dataController.PlusSmartPerSec(dataController.GetF("furniture7Effect"));
                dataController.SetF("maxStamina", DataController.maxStamina + DataController.furniture7Permanent);
                dataController.AddStamina(DataController.furniture7Permanent);
                DataController.maxStamina = dataController.GetF("maxStamina");
                dataController.SetF("house1FurnitureDone", DataController.house1FurnitureDone + 1f);
                DataController.house1FurnitureDone = dataController.GetF("house1FurnitureDone");
            }
        }
        ////// 가구 끝

        ////// 학원 시작
        if(this.name == "academy1BuyButton") //학원1 : 레벨업, 가격은 2배씩, %증가 1, 숫자 증가 1, 체력소모 0.3, 생활비 증가 10000원씩.
        {
            if(dataController.GetF("gold") > dataController.GetF("academy1Price"))
            {
                dataController.SubGold(DataController.academy1Price);
                dataController.SetI("academy1Level", dataController.GetI("academy1Level") + 1);
                DataController.academy1Level = dataController.GetI("academy1Level");
                dataController.SetF("academy1Price", dataController.GetF("academy1Price") * 2f);
                DataController.academy1Price = dataController.GetF("academy1Price");
                dataController.SetF("academy1EffectPercent", dataController.GetF("academy1EffectPercent") + 1f);
                DataController.academy1EffectPercent = dataController.GetF("academy1EffectPercent");
                dataController.SetF("academy1EffectNumber", dataController.GetF("academy1EffectNumber") + 1f);
                DataController.academy1EffectNumber = dataController.GetF("academy1EffectNumber");
                dataController.SetF("academy1SideEffect", dataController.GetF("academy1SideEffect") + 0.3f);
                DataController.academy1SideEffect = dataController.GetF("academy1SideEffect");
                dataController.SetF("academy1UsePerSec", dataController.GetF("academy1UsePerSec") + 10000f);
                DataController.academy1UsePerSec = dataController.GetF("academy1UsePerSec");
                //학원 셋팅끝
                //능력치 셋팅
                dataController.SetF("smartPerSec", dataController.GetF("smartPerSec") + 1f);
                DataController.s_smartPerSec = dataController.GetF("smartPerSec");
                dataController.SetF("smartPercent", dataController.GetF("smartPercent") + 1f);
                DataController.s_smartPercent = dataController.GetF("smartPercent");
                dataController.SetF("usePerSec", dataController.GetF("usePerSec") + 10000f);
                DataController.s_usePerSec = dataController.GetF("usePerSec");
            }
        }
        
        /////진급 시작
        if(this.name == "job1BuyButton")
        {
            int check = (int)Random.Range(1, 100);
            if (dataController.GetF("gold") > dataController.GetF("job1Price") && DataController.job1Name != "회장")
            {
                if (DataController.job1Name == "인턴" && check <= 100 || DataController.job1Name == "사원" && check <= 90 || DataController.job1Name == "대리" && check <= 80
                || DataController.job1Name == "과장" && check <= 70 || DataController.job1Name == "차장" && check <= 60 || DataController.job1Name == "부장" && check <= 50
                || DataController.job1Name == "이사" && check <= 40 || DataController.job1Name == "상무" && check <= 30 || DataController.job1Name == "전무" && check <= 20
                || DataController.job1Name == "사장" && check <= 10 || DataController.job1Name == "회장" && check <= 1)
                {
                    dataController.SubGold(DataController.job1Price); // 돈 줄기
                    if (DataController.job1Name == "인턴")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);

                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 100000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 100000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "사원";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 200000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 200000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }

                    }
                    else if (DataController.job1Name == "사원")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 200000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 200000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "대리";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 300000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 300000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "대리")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 300000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 300000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "과장";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 400000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 400000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "과장")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 400000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 400000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "차장";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 500000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 500000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "차장")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 500000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 500000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "부장";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 600000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 600000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "부장")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 600000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 600000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "이사";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 700000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 700000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "이사")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 700000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 700000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "상무";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 800000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 800000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "상무")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 800000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 800000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "전무";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 900000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 900000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "전무")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 900000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 900000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "사장";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 10f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 1000000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 1000000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "사장")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 1000000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 1000000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level >= 11)
                        {
                            DataController.job1Name = "회장";
                            dataController.SetS("job1Name", DataController.job1Name);
                            DataController.job1Level = 1;
                            dataController.SetF("job1Level", DataController.job1Level);
                            dataController.SetF("job1Percent", dataController.GetF("job1Percent") - 9f);
                            DataController.job1Percent = dataController.GetF("job1Percent");
                            dataController.SetF("job1Price", dataController.GetF("job1Price") + 1100000f); //가격상승
                            DataController.job1Price = dataController.GetF("job1Price");//가격상승

                            dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 1100000f); // 버는돈 상승
                            DataController.job1Earn = dataController.GetF("job1Earn");
                            dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                            DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        }
                    }
                    else if (DataController.job1Name == "회장")
                    {
                        DataController.job1Level = DataController.job1Level + 1f;
                        dataController.SetF("job1Level", DataController.job1Level);
                        dataController.SetF("job1Price", dataController.GetF("job1Price") + 1100000f); //가격상승
                        DataController.job1Price = dataController.GetF("job1Price");//가격상승

                        dataController.SetF("job1Earn", dataController.GetF("job1Earn") + 1100000f); // 버는돈 상승
                        DataController.job1Earn = dataController.GetF("job1Earn");
                        dataController.SetF("goldPerSec", dataController.GetF("job1Earn")); // 버는돈 goldPerSec에도 넣어주기
                        DataController.s_goldPerSec = dataController.GetF("goldPerSec");
                        if (DataController.job1Level == 10)
                        {
                            //끝
                        }
                    }
                }
                else
                {
                    dataController.SubGold(DataController.job1Price);
                    Debug.Log("진급 실패");
                    Debug.Log(check);
                }
            }
            
        }
        //부업 업그레이드
        if(this.name == "Subjob1BuyButton")
        {
            if(DataController.subjobDuring == 0 && dataController.GetF("stamina") > DataController.subjobUpgrade) // 진행중 아닐때. 체력이 요구량보다 많을때
            {
                dataController.SubStamina(DataController.subjobUpgrade);
                dataController.SetF("subjobDuring", 1f);
                DataController.subjobDuring = dataController.GetF("subjobDuring");
                
            }
        }
        //이사가기
        if(this.name == "moveHouseBuyButton" && DataController.house1FurnitureDone == 7) 
        {
            if(dataController.GetF("gold") > DataController.house1Price) // 돈 빼고 스태미너, 지능, 생활비, 산지안산지, 씬 변경, 조건 넣기.
            {
                dataController.SubGold(DataController.house1Price); // 돈 빼기


            }
        }
        
    }
}
