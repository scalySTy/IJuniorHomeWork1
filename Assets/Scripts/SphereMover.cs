using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _movementSpeed = 5f;

    private void Update()
    {
        transform.Translate(_movementDirection * _movementSpeed * Time.deltaTime);
    }
}
