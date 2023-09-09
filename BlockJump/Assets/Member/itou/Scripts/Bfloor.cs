using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bfloor : MonoBehaviour
{
    private GameObject scenemane;
    private Sceneseni sceneseni;
    public GameObject player;
    bool Red = false;
    // Start is called before the first frame update
    void Start()
    {
        scenemane = GameObject.Find("Scenemaneger");
        sceneseni = scenemane.GetComponent<Sceneseni>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Red)
        {
            if (player.GetComponent<SpriteRenderer>().color == Color.red)
            {
                sceneseni._sceneNumber = 4;
                SceneManager.LoadScene("Gameover");
            }
            Red = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
            Red = true;
    }
}
