using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.Instance.PlayBGM(BGMName.Title);
    }
}
