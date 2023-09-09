using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magma : MonoBehaviour
{
    [SerializeField]
    private float magmaSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSceneManager.Instance.IsGameOver == true) { return; }
        transform.position += new Vector3(0, magmaSpeed * Time.deltaTime, 0);
    }
}
