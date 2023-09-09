using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rfloor : MonoBehaviour
{
    private GameObject scenemane;
    private Sceneseni sceneseni;
    public GameObject _player;
    bool Blue = false;
    // Start is called before the first frame update
    void Start()
    {
        scenemane = GameObject.Find("Scenemaneger");
        sceneseni = scenemane.GetComponent<Sceneseni>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Blue)
        {
            if (_player.GetComponent<SpriteRenderer>().color == Color.blue)
            {
                sceneseni._sceneNumber = 4;
                SceneManager.LoadScene("Gameover");
            }
            Blue = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
            Blue = true;
    }
}
