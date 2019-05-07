using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //config params
    [SerializeField] float screenWidth = 16f;
    float minX = 1f;
    float maxX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosition = Input.mousePosition.x / Screen.width * screenWidth;
        Vector2 paddlePosition = new Vector2(mousePosition, 0.35f)
        {
            x = Mathf.Clamp(mousePosition, minX, maxX)
        };
        transform.position = paddlePosition;
    }
}
