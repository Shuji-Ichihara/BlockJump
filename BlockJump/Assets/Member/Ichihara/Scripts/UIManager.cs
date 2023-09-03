using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    // 取った星の数を表示
    [SerializeField]
    private TextMeshProUGUI _starCountupText = null;

    // Start is called before the first frame update
    void Start()
    {
        if(_starCountupText == null)
        {
            _starCountupText = GameObject.Find("StarCountupText").GetComponent<TextMeshProUGUI>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
