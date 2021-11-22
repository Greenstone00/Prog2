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
    private float delayBeforeLoading = 2.5f; // ha kinyírjuk az egeret, ennyi idõt várjunk meilõtt betöltjük a következõ pályát
    private float timeElapsed;

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
        timeElapsed += Time.deltaTime;  // várakozatás hogy ne frame-rõl framere menjen a kövi pálya
        if (timeElapsed > delayBeforeLoading)  
        {
            SceneManager.LoadScene(nextLevelName);
        }
            //Ha végig vittük volna a játékot és újra akarnánk játszani, tudja tölteni a pájákat továbbra is
        if (_nextLevelIndex >= 11)
        {
            _nextLevelIndex = 1;
        }
    }
}

