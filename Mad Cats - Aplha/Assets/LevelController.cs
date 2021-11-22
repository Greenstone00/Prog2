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
    private float delayBeforeLoading = 2.5f; // ha kiny�rjuk az egeret, ennyi id�t v�rjunk meil�tt bet�ltj�k a k�vetkez� p�ly�t
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
        timeElapsed += Time.deltaTime;  // v�rakozat�s hogy ne frame-r�l framere menjen a k�vi p�lya
        if (timeElapsed > delayBeforeLoading)  
        {
            SceneManager.LoadScene(nextLevelName);
        }
            //Ha v�gig vitt�k volna a j�t�kot �s �jra akarn�nk j�tszani, tudja t�lteni a p�j�kat tov�bbra is
        if (_nextLevelIndex >= 11)
        {
            _nextLevelIndex = 1;
        }
    }
}

