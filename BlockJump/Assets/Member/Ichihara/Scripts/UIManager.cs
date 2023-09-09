using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    [SerializeField]
    private Canvas _gameUICanvas = null;
    [SerializeField]
    private Canvas _resultUICanvas = null;

    // 取った星の数を表示
    [SerializeField]
    private TextMeshProUGUI _starCountupText = null;
    // ブロックのステータス案内を表示するテキスト
    [SerializeField]
    private TextMeshProUGUI _playerStatusText = null;
    // ゲームオーバーのテキスト
    [SerializeField]
    private TextMeshProUGUI _gameOverText = null;

    [SerializeField]
    private string _status = "Status";
    // 現在のブロックの色を表示するイメージ画像
    [SerializeField]
    private Image _playerStatusImage = null;

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
        if(_gameOverText == null)
        {
            _gameOverText = GameObject.Find("GameOverText").GetComponent<TextMeshProUGUI>();
        }
        if (_playerStatusImage == null)
        {
            _playerStatusImage = GameObject.Find("Status").GetComponent<Image>();
        }
        _playerStatusText.text = _status;
        _gameOverText.text = "GameOver";
        _gameOverText.color = Color.black;
        _gameUICanvas.worldCamera = GameObject.Find("PlayerBlock").GetComponentInChildren<Camera>();
        _resultUICanvas.worldCamera = GameObject.Find("PlayerBlock").GetComponentInChildren<Camera>();
        _gameUICanvas.gameObject.SetActive(true);
        _resultUICanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        PreviewStarCount();
        if (GameSceneManager.Instance.IsGameOver == true || GameSceneManager.Instance.IsGoal == true)
        {
            _gameUICanvas.gameObject.SetActive(false);
            _resultUICanvas.gameObject.SetActive(true);
        }
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
    /// <param name="status">現在のプレイヤーのステータス</param>
    public void PreviewPlayerStatus(PlayerStatus status)
    {
        if (status == PlayerStatus.Blue)
        {
            // ここでプレイヤーの画像を取得する
            PlayerController playerController= GameSceneManager.Instance.Player.GetComponent<PlayerController>();
            _playerStatusImage.color = playerController.SpriteColor[(int)status];
        }
        else if (status == PlayerStatus.Red)
        {
            // ここでプレイヤーの画像を取得する
            PlayerController playerController = GameSceneManager.Instance.Player.GetComponent<PlayerController>();
            _playerStatusImage.color = playerController.SpriteColor[(int)status];
        }
    }
}
