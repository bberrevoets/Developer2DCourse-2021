// =====================================================================
// Created  : 27-03-2022    10:31
// Updated  : 27-03-2022    11:10
// 
// Solution: Delivery Driver
// Project:  Assembly-CSharp
// Filename: Driver.cs
// =====================================================================

using UnityEngine;

public class Driver : MonoBehaviour
{
    private float _moveSpeed = 0.01f;
    private float _steerSpeed = 1f;

    private void Update()
    {
        transform.Rotate(0, 0, _steerSpeed);
        transform.Translate(0, _moveSpeed, 0);
    }
}
