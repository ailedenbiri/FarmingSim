using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashManager : MonoBehaviour
{
    public static CashManager instance;
    private int coins;
    private string keyCoins = "keyCoins";


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            instance = this;
        }
    }

    public void AddCoin(int price)
    {
        coins += price;
        DisplayCoins();
    }

    private void SpendCoins(int price)
    {
        coins -= price;
        DisplayCoins();
    }

    public bool TryBuyThisUnit(int price)
    {
        if(GetCoins() >= price)
        {
            SpendCoins(price);
            return true;
        }
        return false;
    }

    private void Start()
    {
        LoadCash();
        DisplayCoins();
    }



    public int GetCoins()
    {
        return coins;
    }


    public void ExchangeProduct(ProductData productData)
    {
        AddCoin(productData.productPrice);
    }

    private void DisplayCoins()
    {
        UIManager.Instance.ShowCoinCountOnScreen(coins);
        SaveCash();
    }

    private void LoadCash()
    {
        coins = PlayerPrefs.GetInt("keyCoins", 0);
    }
   
    private void SaveCash()
    {
        PlayerPrefs.SetInt("keyCoins", coins);
    }

}
