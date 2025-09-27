using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWallBehaviour : MonoBehaviour
{
    public LivesManager livesManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            livesManager.LoseLife();
        }
    }
}