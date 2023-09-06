using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 現在のプレイヤーの状態
/// </summary>
public enum Status
{
    Blue,
    Red,
}

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    // 取った星の数を表示
    [SerializeField]
    private TextMeshProUGUI _starCountupText = null;
    // ブロックのステータス案内を表示するテキスト
    [SerializeField]
    private TextMeshProUGUI _playerStatusText = null;
    [SerializeField]
    private string _status = "Status";
    // 現在のブロックの色を表示するイメージ画像
    [SerializeField]
    private Image _playerStatus = null;

    // Start is called before the first frame update
    void Start()
    {
        if (_starCountupText == null)
        {
            _starCountupText = GameObject.Find("StarCountupText").GetComponent<TextMeshProUGUI>();
        }
        if (_playerStatusText == null)
        {
            _playerStatusText = GameObject.Find("PlayerStatusText").GetComponent<TextMeshProUGUI>();
        }
        if (_playerStatus == null)
        {
            _playerStatus = GameObject.Find("Status").GetComponent<Image>();
        }
        _playerStatusText.text = _status;
    }

    // Update is called once per frame
    void Update()
    {
        PreviewStarCount();
    }

    /// <summary>
    /// ブロックが獲得した星の数をテキスト表示する
    /// </summary>
    private void PreviewStarCount()
    {
        _starCountupText.text = ": " + GameSceneManager.Instance.StarCount.ToString();
    }

    /// <summary>
    /// プレイヤーのステータスを UI に反映する
    /// </summary>
    /// <param name="status"></param>
    public void PreviewPlayerStatus(Status status)
    {
        if(status == Status.Blue)
        {
            // ここでプレイヤーの画像を取得する
        }
        else if(status == Status.Red)
        {
            // ここでプレイヤーの画像を取得する
        }
    }
}
