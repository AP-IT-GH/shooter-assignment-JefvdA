using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    private const float maxTime = 5f;
    private float _timer = 0f;

    private void Update()
    {
        if (_timer < maxTime)
            _timer += Time.deltaTime;
        else
            Destroy(gameObject);
    }
}
