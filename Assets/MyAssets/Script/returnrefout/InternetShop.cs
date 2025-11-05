using System.Collections.Generic;
using UnityEngine;

public class InternetShop : MonoBehaviour
{
    public delegate void PurchaseHandler(int id);
    public event PurchaseHandler OnPurchase;
    [SerializeField] private List<GameObject> internets;
    [SerializeField] private GameObject parentBuy;
    [SerializeField] private InternetShopClassItem _prefab;
    [SerializeField] private Sprite[] _icon;
    [SerializeField] private string[] _names;
    [SerializeField] private float[] _price;

    private void Start()
    {
        OnPurchase = OnAddingInMarket;
        for (int i = 0; i < _icon.Length; i++)
        {
            InternetShopClassItem prefab = Instantiate(_prefab, parentBuy.transform);
            prefab.id = i;
            prefab.inzalizate(_price [i], _names[i], _icon[i]);
            
        }
    }

    private void OnAddingInMarket(int id)
    {
        
    }
}
