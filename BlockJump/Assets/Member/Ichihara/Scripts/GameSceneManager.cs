using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameSceneManager : SingletonMonoBehaviour<GameSceneManager>
{
    [SerializeField]
    private Transform _startPosition = null;
    [SerializeField]
    private Transform _goalPosition = null;
    [SerializeField]
    private List<Transform> _starPosition = null;

    [SerializeField]
    private GameObject _player = null;
    public GameObject Player => _player;
    [SerializeField]
    private GameObject _goal = null;
    [SerializeField]
    private GameObject _star = null;
    [SerializeField, Range(0, 5)]
    private int _initStar = 0;

    // プレイヤーが獲得した星の数
    private int _starCount = 0;
    public int StarCount => _starCount;
    // ゴール判定
    private bool _isGoal = false;
    public bool IsGoal => _isGoal;
    // ゲームオーバー判定
    private bool _isGameOver = false;
    public bool IsGameOver => _isGameOver;

    new private void Awake()
    {
        InitGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        _starCount = 0;
        _isGameOver = false;
        _isGoal = false;
    }

    /// <summary>
    /// ゲームに必要なオブジェクト生成
    /// </summary>
    private void InitGame()
    {
        Instantiate(_player, _startPosition);
        Instantiate(_goal, _goalPosition);
        // 事前に設定した座標にランダムに星を生成
        List<int> initStarCount = new List<int>();
        while (initStarCount.Count < _initStar)
        {
            int randomNumber = Random.Range(0, _starPosition.Count);
            int dummyNumber = randomNumber;
            bool continueFlag = false;
            if (initStarCount.Count > 0)
            {
                for (int i = 0; i < initStarCount.Count; i++)
                {
                    if (dummyNumber == initStarCount[i])
                    {
                        continueFlag = true;
                    }
                }
                if (true == continueFlag) { continue; }
            }
            Instantiate(_star, _starPosition[randomNumber]);
            initStarCount.Add(randomNumber);
        }
    }

    /// <summary>
    /// プレイヤーがゴールにした時に呼び出す
    /// </summary>
    public void PlayerReachesGoal()
    {
        _isGoal = true;
    }

    /// <summary>
    /// プレイヤーが星を取得した時に呼び出す
    /// </summary>
    public void CountupStar()
    {
        _starCount++;
    }

    public void GameOver()
    {
        _isGameOver = true;
    }
}
