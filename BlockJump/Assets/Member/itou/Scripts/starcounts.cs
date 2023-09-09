using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starcounts : MonoBehaviour
{
    public PlayerController _controller;
    public Text _star;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _star.text = "starcount : " + _controller.starcount + "/3";
    }
}
