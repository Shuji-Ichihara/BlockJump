using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Magma : MonoBehaviour
{
    private GameObject scenemane;
    private Sceneseni sceneseni;
    // Start is called before the first frame update
    void Start()
    {
        scenemane = GameObject.Find("Scenemaneger");
        sceneseni = scenemane.GetComponent<Sceneseni>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0.5f * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sceneseni._sceneNumber = 4;
            SceneManager.LoadScene("Gameover");
        }
    }
}
