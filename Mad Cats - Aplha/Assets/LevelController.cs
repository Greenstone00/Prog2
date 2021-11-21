using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private Enemy[] _enemies;
    public Animator transition;
    public float transitionTime = 10f;

    private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
            {
                return;
            }
        }

        Debug.Log("You have killed all 'enemies'!");

        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        transition.SetTrigger("Start");

        SceneManager.LoadScene(nextLevelName);
        //Ha végig vittük volna a játékot és újra akarnánk játszani, tudja tölteni a pájákat továbbra is
        if (_nextLevelIndex >= 7)
        {
            _nextLevelIndex = 1;
        }
    }
}

