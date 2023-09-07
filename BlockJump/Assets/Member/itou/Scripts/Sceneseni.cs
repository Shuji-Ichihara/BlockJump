using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneseni : MonoBehaviour
{
    private int _sceneNumber = 0;
    private int _maxSceneNumber;
    //[SerializeField]
    //bool kari = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        _maxSceneNumber = SceneManager.sceneCountInBuildSettings - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(_sceneNumber != 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_sceneNumber < _maxSceneNumber)
                {
                    _sceneNumber++;
                    SceneManager.LoadScene(_sceneNumber);
                }
                else if (_sceneNumber == _maxSceneNumber)
                {
                    _sceneNumber = 0;
                    SceneManager.LoadScene(_sceneNumber);
                }
            }
        }
        //ƒS[ƒ‹Žž‚Ébool‚ð‚à‚ç‚Á‚Ä‚­‚é@’Ç‹Lkaribool‚ÍÁ‚µ‚Ä‚æ‚¢
        if (GameSceneManager.Instance != null && GameSceneManager.Instance.IsGoal == true)
        {
            //kari = false;
            _sceneNumber++;
            SceneManager.LoadScene(_sceneNumber);
        }
    }
}
