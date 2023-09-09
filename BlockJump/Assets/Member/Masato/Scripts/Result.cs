using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    private void Awake()
    {
        AudioManager.Instance.PlayBGM(BGMName.End);
    }
}
