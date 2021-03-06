﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    private Enemy[] _enemies;
    private static int _nextLevelIndex = 1;
    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Enemy enemy in _enemies)
        {
            if(enemy != null)
            {
                return;
            }
        }
        _nextLevelIndex++;
        string nextLevelName = "Level " + _nextLevelIndex;
        if(_nextLevelIndex < 5){
            Bird.numOfLifes = 3;
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
