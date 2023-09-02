using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneseni : MonoBehaviour
{
    private int _sceneNumber = 0;
    [SerializeField]
    private int _maxSceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(_sceneNumber < _maxSceneNumber)
            {
                _sceneNumber++;
                SceneManager.LoadScene(_sceneNumber);
            }
            else if(_sceneNumber == _maxSceneNumber)
            {
                _sceneNumber = 0;
                SceneManager.LoadScene(_sceneNumber);
            }
        }
    }
}
