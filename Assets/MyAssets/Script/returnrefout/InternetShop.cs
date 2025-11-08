using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InternetShop : MonoBehaviour
{
    [SerializeField] private List<GameObject> internets;
    [SerializeField] private GameObject parentBuy;
    [SerializeField] private InternetShopClassItem _prefab;
    [SerializeField] private GameObject _market;
    [SerializeField] private Sprite[] _icon;
    [SerializeField] private string[] _names;
    [SerializeField] private float[] _price;
    public List<InternerShopValue> _values = new List<InternerShopValue>();
    [SerializeField] private TMP_Text _itotal;

    private void Start()
    {
        for (int i = 0; i < _icon.Length; i++)
        {
            InternetShopClassItem prefab = Instantiate(_prefab, parentBuy.transform);
            prefab._InternetShop = this;
            prefab.id = i;
            prefab.inzalizate(_price[i], _names[i], _icon[i]);

        }
    }

    public void OnAddingInMarket(int id)
    {
        InternerShopValue internerShopValue = new InternerShopValue();
        internerShopValue.Name = _names[id];
        internerShopValue.Price = _price[id];
        _values.Add(internerShopValue);
        TotalCalculator();
    }

    public void RequestToBasket()
    {
        float total = 0;
        foreach (var item in _values)
        {
            print($"item: {item.Name} price: {item.Price}");
            total += item.Price;
        }
        _itotal.text = total.ToString();
        print($"total is: {total}");
    }

    public void NextDay()
    {
        for (int i = 0; i < _price.Length; i++)
        {
            _price[i] *= 2f;
        }

        foreach (var price in _values)
        {
            price.Price *= 2;
        }

        TotalCalculator();
    }

    private void TotalCalculator()
    {
        float total = 0;
        foreach (var price in _values)
        {
            total += price.Price;
        }

        _itotal.text = total.ToString();
    }

}
