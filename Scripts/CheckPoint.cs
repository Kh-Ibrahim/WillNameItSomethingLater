using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    GameController gameController;
    public Transform respawnPoint;
    Collider2D coll;
    private void Awake()
    {
        gameController= GameObject.FindGameObjectWithTag("Player").GetComponent<GameController>();
        coll = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameController.UpdateCheckpoint(respawnPoint.position);
            coll.enabled = false;
        }
    }
}
