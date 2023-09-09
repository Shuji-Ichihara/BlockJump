using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneseni : MonoBehaviour
{
    public int _sceneNumber = 0;
    [SerializeField]
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
        if (_sceneNumber != 1 && _sceneNumber != 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_sceneNumber < _maxSceneNumber - 1)
                {
                    _sceneNumber++;
                    SceneManager.LoadScene(_sceneNumber);
                }
                else if (_sceneNumber == _maxSceneNumber - 1)
                {
                    _sceneNumber = 0;
                    SceneManager.LoadScene(_sceneNumber);
                }
                else if (_sceneNumber == _maxSceneNumber)
                {
                    _sceneNumber = 0;
                    SceneManager.LoadScene(_sceneNumber);
                }
            }
        }
        //ゴール時にboolをもらってくる　追記kariboolは消してよい
        if (GameSceneManager.Instance != null && GameSceneManager.Instance.IsGoal == true)
        {
            //kari = false;
            _sceneNumber++;
            SceneManager.LoadScene(_sceneNumber);
        }
    }
}
