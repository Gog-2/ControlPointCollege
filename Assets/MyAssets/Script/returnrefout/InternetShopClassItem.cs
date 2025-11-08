using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InternetShopClassItem : MonoBehaviour
{
    public Image icon;
    public TMP_Text Name;
    [SerializeField]private TMP_Text _iprice;
    public float Price = 0;
    public int id = 0;
    public InternetShop _InternetShop;

    public void inzalizate(float price,string nameItem,Sprite iconInzalize)
    {
        icon.sprite = iconInzalize;
        Name.text = nameItem;
        Price = price;
        _iprice.text = price.ToString();
    }

    public void Buy()
    {
        _InternetShop.OnAddingInMarket(id);
    }
}

