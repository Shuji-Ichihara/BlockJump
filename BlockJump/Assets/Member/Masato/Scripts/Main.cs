using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.Instance.PlayBGM(BGMName.Main);
    }
}
