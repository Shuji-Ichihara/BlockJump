using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerStatus
{
    Red,
    Blue,
}

public class PlayerController : MonoBehaviour
{
    public PlayerStatus playerStatus = PlayerStatus.Red;

    public float jumpForce = 5f; // ジャンプ力
    //public float moveSpeed = 5f; // 移動速度

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer = null;

    [SerializeField]
    private Color[] spriteColor = { };
    public Color[] SpriteColor => spriteColor;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerStatus = PlayerStatus.Red;
        spriteRenderer.color = spriteColor[(int)playerStatus];
    }

    private void Update()
    {
        if (GameSceneManager.Instance.IsGameOver == true) { return; }

        // 左クリック
        if (Input.GetMouseButtonDown(0))
        {
            JumpToLeftTop();
        }

        // 右クリック
        if (Input.GetMouseButtonDown(1))
        {
            JumpToRightTop();
        }
    }

    private void JumpToLeftTop()
    {
        Vector2 jumpDirection = new Vector2(-1f, 1f).normalized;
        rb.velocity = jumpDirection * jumpForce;
    }

    private void JumpToRightTop()
    {
        Vector2 jumpDirection = new Vector2(1f, 1f).normalized;
        rb.velocity = jumpDirection * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        bool magma = other.gameObject.CompareTag("Enemy");
        if (true == magma)
        {
            GameSceneManager.Instance.GameOver();
        }
        else if (true == other.gameObject.CompareTag("Finish"))
        {
            GameSceneManager.Instance.PlayerReachesGoal();
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        bool redTile = other.gameObject.CompareTag("RedTile");
        bool blueTile = other.gameObject.CompareTag("BlueTile");
        if (true == redTile && playerStatus == PlayerStatus.Blue)
        {
            GameSceneManager.Instance.GameOver();
        }
        else if (true == blueTile && playerStatus == PlayerStatus.Red)
        {
            GameSceneManager.Instance.GameOver();
        }
        else { return; }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (true == other.gameObject.CompareTag("Star"))
        {
            GameSceneManager.Instance.CountupStar();
            Destroy(other.gameObject);
        }
        else if (true == other.gameObject.CompareTag("RedBall"))
        {
            spriteRenderer.color = spriteColor[(int)PlayerStatus.Red];
            playerStatus = PlayerStatus.Red;
            UIManager.Instance.PreviewPlayerStatus(PlayerStatus.Red);
        }
        else if (true == other.gameObject.CompareTag("BlueBall"))
        {
            spriteRenderer.color = spriteColor[(int)PlayerStatus.Blue];
            playerStatus = PlayerStatus.Blue;
            UIManager.Instance.PreviewPlayerStatus(PlayerStatus.Blue);
        }

    }
}