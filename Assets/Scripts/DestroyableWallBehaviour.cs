using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableWallBehaviour : MonoBehaviour
{
    public ScoreManager scoreManager;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            scoreManager.SendMessage("AddScore");
            Destroy(gameObject);
        }
    }
}
