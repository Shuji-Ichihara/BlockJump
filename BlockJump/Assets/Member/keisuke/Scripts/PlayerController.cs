using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f; // ジャンプ力
    public float moveSpeed = 5f; // 移動速度

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
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
}