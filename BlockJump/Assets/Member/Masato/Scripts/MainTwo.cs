using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTwo : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.Instance.PlayBGM(BGMName.Main);
    }
}
