using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEditor.Experimental.GraphView;
using TMPro;
using UnityEngine.UIElements;

public class BankClinet : MonoBehaviour
{
    private int realMoney = 100000;
    private int AtmMoney = 50000;

    public TMP_InputField Get_Moneyinput;
    public TMP_InputField Give_Moneyinput;

    public TextMeshProUGUI realMoney_Text;
    public TextMeshProUGUI AtmMoney_Text;
    public GameObject DontMoney;


    void Start()
    {

    }
    private void Update()
    {
        realMoney_Text.text = String.Format("{0:#,0}", realMoney);
        AtmMoney_Text.text = String.Format("{0:#,0}", AtmMoney);

    }


    public void GetMoney(int Money)
    {
        realMoney -= Money;
        AtmMoney += Money;
    }
    public void GetMoney10000()
    {
        if(realMoney < 10000) { DontMoney.SetActive(true);  }
        else { GetMoney(10000); }
    }
    public void GetMoney30000()
    {
        if (realMoney < 30000) { DontMoney.SetActive(true); }
        else { GetMoney(30000); }
    }
    public void GetMoney50000()
    {
        if (realMoney < 50000) { DontMoney.SetActive(true); }
        else { GetMoney(50000); }
    }
    public void GetMoney_select()
    {
        int wantMoney;
        wantMoney = Convert.ToInt32(Get_Moneyinput.text);

        if (realMoney < wantMoney) { DontMoney.SetActive(true); }
        else { GetMoney(wantMoney); }
    }
    
    public void GiveMoney(int Money)
    {
        realMoney += Money;
        AtmMoney -= Money;
    }
    public void GiveMoney_select()
    {
        int wantMoney;
        wantMoney = Convert.ToInt32(Give_Moneyinput.text);
        
        if (AtmMoney < wantMoney) { DontMoney.SetActive(true); }
        else { GiveMoney(wantMoney); }
    }
    public void GiveMoney10000()
    {
        if (AtmMoney < 10000) { DontMoney.SetActive(true); }
        else { GiveMoney(10000); }
    }
    public void GiveMoney30000()
    {
        if (AtmMoney < 50000) { DontMoney.SetActive(true); }
        else { GiveMoney(50000); }
    }
    public void GiveMoney50000()
    {
        if (AtmMoney < 50000) { DontMoney.SetActive(true); }
        else { GiveMoney(50000); }
    }

}
