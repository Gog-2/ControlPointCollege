using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyChanger : MonoBehaviour
{
    [SerializeField] private TMP_InputField _lvlInputField, _healthInputField,_nameInputField;
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Transform _spawnPointMin, _spawnPointMax;
    [SerializeField] private string[] _namesVariation;
    private string _name;
    [SerializeField] private int _minhealth;
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _maxLevel;
    [SerializeField] private int _howMuchSpawn;
    public List<Enemy> enemies;
    private void Start()
    {
        SpawnCubes();
    }

    private void SpawnCubes()
    {
        for (int i = 0; i < _howMuchSpawn; i++)
        {
            Vector3 spawnPos;
            float randomX = Random.Range(_spawnPointMin.position.x, _spawnPointMax.position.x);
            spawnPos = new Vector3(randomX, _spawnPointMin.position.y, 0);
            Enemy prefab = Instantiate(_prefab, spawnPos, Quaternion.identity);
            prefab.Health = Random.Range(1, _maxHealth);
            prefab.Lvl = Random.Range(1, _maxLevel);
            prefab.Name = _namesVariation[Random.Range(1, _namesVariation.Length)];
            enemies.Add(prefab);
        }
    }

    public void CheckLvl()
    {
        foreach (var enemy in enemies)
        {
            if (enemy.Lvl < Convert.ToInt32(_lvlInputField.text))
            {
                enemy.gameObject.SetActive(false);
            }
        }
    }

    public void CheckHealth()
    {
        foreach (var enemy in enemies)
        {
            if (enemy.Health < Convert.ToInt32(_healthInputField.text))
            {
                enemy.gameObject.SetActive(false);
            }
        } 
    }

    public void CheckName()
    {
        foreach (var enemy in enemies)
        {
            if (enemy.Name == _nameInputField.text)
            {
                enemy.MakeBoss();
            }
        } 
    }

    public void ShowCubes()
    {
        foreach (var enemy in enemies)
        {
            enemy.gameObject.SetActive(true);
        }
    }
}
