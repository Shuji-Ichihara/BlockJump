using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f; // �W�����v��
    public float moveSpeed = 5f; // �ړ����x

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // ���N���b�N
        if (Input.GetMouseButtonDown(0))
        {
            JumpToLeftTop();
        }

        // �E�N���b�N
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