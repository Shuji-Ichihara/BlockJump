using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneManager : SingletonMonoBehaviour<GameSceneManager>
{
    // プレイヤーが獲得した星の数
    private int _starCount = 0;
    public int StarCount => _starCount;
    // ゴール判定
    private bool _isGoal = false;
    public bool IsGoal => _isGoal;

    // Start is called before the first frame update
    void Start()
    {
        _starCount = 0;
        _isGoal = false;
    }

    /// <summary>
    /// プレイヤーがゴールにした時に呼び出す
    /// </summary>
    public void PlayerReachesGoal()
    {
        _isGoal = true;
    }

    public void PlayerReachesGoals()
    {
        _isGoal = false;
    }

    /// <summary>
    /// プレイヤーが星を取得した時に呼び出す
    /// </summary>
    public void CountupStar()
    {
        _starCount++;
    }
}
