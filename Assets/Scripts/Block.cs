using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        Destroy(gameObject, 0.5f); // "gameObject" is like the keyword "this" in Java;
    }
}
