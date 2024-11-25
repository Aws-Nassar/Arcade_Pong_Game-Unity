using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongGame : MonoBehaviour
{
    public float paddleSpeed = 5f;
    public float ballSpeed = 10f;
    private Vector3 ballDirection;
    public Transform leftPaddle;
    public Transform rightPaddle;
    public Transform ball;
    private float paddleMinY = 8.123156f;
    private float paddleMaxY = 9.532f;
    void Start()
    {
        ballDirection = new Vector3(0, Random.Range(-1f, 1f), -1);
    }

    void Update()
    {
        MovePaddles();
        MoveBall();
    }

    void MovePaddles()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (leftPaddle.position.y < paddleMaxY)
            {
                leftPaddle.position += new Vector3(0, paddleSpeed * Time.deltaTime, 0);
            }
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (leftPaddle.position.y > paddleMinY)
            {
                leftPaddle.position -= new Vector3(0, paddleSpeed * Time.deltaTime, 0);
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (rightPaddle.position.y < paddleMaxY)
            {
                rightPaddle.position += new Vector3(0, paddleSpeed * Time.deltaTime, 0);
            }
        }

        else if (Input.GetKey(KeyCode.S))
        {
            if (rightPaddle.position.y > paddleMinY)
            {
                rightPaddle.position -= new Vector3(0, paddleSpeed * Time.deltaTime, 0);
            }
        }
    }

    void MoveBall()
    {
        ball.position += ballDirection * ballSpeed * Time.deltaTime;

        if (ball.position.y >= 8.123156f)
        {
            ballDirection.y = -ballDirection.y;
        }

        if (ball.position.y <= 9.532f)
        {
            ballDirection.y = -ballDirection.y;
        }

        if (ball.position.z >= 1.65f)
        {
            ballDirection.z = -ballDirection.z;
        }

        if (ball.position.z <= -0.96f)
        {
            ballDirection.z = -ballDirection.z;
        }
    }
}
