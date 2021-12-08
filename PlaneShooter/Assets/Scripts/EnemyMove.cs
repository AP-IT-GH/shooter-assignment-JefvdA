using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float upSpeed = 1f;
    [SerializeField] private float spinSpeed = 50f;

    private void Update()
    {
        transform.Rotate(Vector3.up * (spinSpeed * Time.deltaTime));
        
        transform.Translate(Vector3.up * (Mathf.Cos(Time.timeSinceLevelLoad) * upSpeed * Time.deltaTime));
    }
}
