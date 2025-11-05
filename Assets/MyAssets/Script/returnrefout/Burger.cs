using System;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour
{
[SerializeField]private List<string> _input;
[SerializeField]private List<string> _bigmac;
[SerializeField]private List<string> _chezburger;
private string _answer;
private void Start()
{
    int _bigmacPoint = 0,_chezburgerPoint = 0;
    foreach (var ingridient in _input)
    {
        if (_bigmac.Contains(ingridient))
        {
            _bigmacPoint++;
        }
        if (_chezburger.Contains(ingridient))
        {
            _chezburgerPoint++;
        }
    }
    CheckAnswer(out _answer,_bigmacPoint, _chezburgerPoint);
    print(_answer);
    
}

private void CheckAnswer(out string answer,int bigmacPoint,int chezburgerPoint)
{
    if (bigmacPoint == _bigmac.Count)
    {
        answer = "Big mac";    
    }
    else if (chezburgerPoint == _chezburger.Count)
    {
        answer = "Chez burger";
    }
    else
    {
        answer = "no one";
    }
}
}
