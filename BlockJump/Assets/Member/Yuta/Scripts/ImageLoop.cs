using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageLoop : MonoBehaviour
{
    void Start()
    {
        //‰Šú‰»
        Vector2 offset = new Vector2(0, 0);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    // Update is called once per frame
    void Update()
    {
        //‰æ‘œ‚ğƒXƒNƒ[ƒ‹‚·‚éˆ—
        float scroll = Mathf.Repeat(Time.time * -0.05f, 1);
        Vector2 offset = new Vector2(scroll, 0);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
