using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformChanger : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 5f;
    [SerializeField] private float _scaleSpeed = 5f;


    private void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
