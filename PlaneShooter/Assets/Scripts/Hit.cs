using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    private void OnTriggerEnter(Collider other)
    {
        gameManager.Score += 1;
        Destroy(gameObject);
    }
}
