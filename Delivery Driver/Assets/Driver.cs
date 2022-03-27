// =====================================================================
// Created  : 27-03-2022    10:31
// Updated  : 27-03-2022    11:00
// 
// Solution: Delivery Driver
// Project:  Assembly-CSharp
// Filename: Driver.cs
// =====================================================================

using UnityEngine;

public class Driver : MonoBehaviour
{
    private void Start()
    {
    }

    private void Update()
    {
        transform.Rotate(0, 0, 0.1f);
        transform.Translate(0, 0.01f, 0);
    }
}
