using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
[SerializeField] private TMP_Text _ihealth;
[SerializeField] private TMP_Text _ilvl;
[SerializeField] private TMP_Text _iname;
[SerializeField] private int _maxHealthRnd;
[SerializeField] private int _maxLevelRnd;
[SerializeField] private string[] _namesVariation;
[Header("Stats")]
[SerializeField] private int _health;
[SerializeField]private int _lvl;
[SerializeField]private string _name;
[SerializeField]private bool _isBoss = false;
public int Health
{
    get => _health;
    set
    {
        _health = value;
        _ihealth.text = $"Heath:{_health}";
    }
}
public int Lvl
{
    get => _lvl;
    set
    {
        _lvl = value;
        _ilvl.text = $"Lvl.{_lvl}";
    }
}
public string Name
{
    get => _name;
    set
    {
        _name = value;
        _iname.text = _name;
    }
}
private void OnValidate()
{
        _iname.text = _name;
        _ihealth.text = $"Health:{_health}";
        _ilvl.text = $"Lvl.{_lvl}";
}
public void MakeBoss()
{
    if (!_isBoss)
    {
        Name = "Boss";
        Lvl++;
        Health *= 3;
        _isBoss = true;
    }
}
}
