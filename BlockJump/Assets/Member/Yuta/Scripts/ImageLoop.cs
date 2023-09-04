using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageLoop : MonoBehaviour
{
    void Start()
    {
        //初期化
        Vector2 offset = new Vector2(0, 0);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    // Update is called once per frame
    void Update()
    {
        //画像をスクロールする処理
        float scroll = Mathf.Repeat(Time.time * -0.05f, 1);
        Vector2 offset = new Vector2(scroll, 0);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
