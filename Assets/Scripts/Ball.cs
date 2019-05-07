using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool ballLaunched = false;
    [SerializeField] Paddle paddle;
    [SerializeField] AudioClip[] audioClips;
    Vector2 ballToPaddleDistance;

    // Cached Component References
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        ballToPaddleDistance = transform.position - paddle.transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!ballLaunched)
        {
            BallPaddleLock();

        } 
        LaunchOnMouseClick();
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ballLaunched = true;
            if (!ballLaunched)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
            }
        }
    }

    //locks the ball onto the paddle
    private void BallPaddleLock()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + ballToPaddleDistance;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ballLaunched)
        {
            AudioClip clip = audioClips[UnityEngine.Random.Range(0, audioClips.Length)];
            audioSource.PlayOneShot(clip);
        }
    }
}
